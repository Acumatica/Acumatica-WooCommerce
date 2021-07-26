using Core.Log;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ACSC.Tests.EntityValidators
{
    public partial class EntityComparer
    {
        #region Singleton

        private static readonly Lazy<EntityComparer> _service = new Lazy<EntityComparer>(() => new EntityComparer());
        public static EntityComparer Instance { get { return _service.Value; } }

        private EntityComparer()
        {
            /*Singleton*/
            BrockenRules = new List<CompareResult>();
        }

        #endregion Singleton

        public List<CompareResult> BrockenRules { get; private set; }

        public bool IsValid => BrockenRules == null || BrockenRules.Count == 0;

        public EntityComparer Validate(object etalon, object target)
        {
            BrockenRules.Clear();
            try
            {
                Compare(etalon, target);
            }
            catch (Exception e)
            {
                BrockenRules.Add(new CompareResult(e));
            }

            return Instance;
        }

        public EntityComparer Trace(string operaton)
        {
            Log.Information(operaton);
            var error = GetErrorString();
            if (!string.IsNullOrEmpty(error))
            {
                Log.Error(error);
            }
            else
            {
                Log.Information("Validation success.");
            }

            return Instance;
        }

        private  string GetErrorString()
        {
            if (BrockenRules != null)
            {
                var sb = new StringBuilder();
                BrockenRules.Select(r => sb.AppendLine(r.ToString()))
                            .ToList();
                return sb.ToString();
            }

            return string.Empty;
        }

        #region Private Methods

        private List<CompareResult> Compare(object expected, object actual)
        {
            if (expected == null)
            {
                throw new Exception("Compare error: Expected object is null");
            }

            if (actual == null)
            {
                throw new Exception("Compare error: Actual object is null");
            }

            var etalonDict = new Dictionary<string, object>();
            var targetDict = new Dictionary<string, object>();
            IterateProperties(expected, etalonDict);
            IterateProperties(actual, targetDict);

            BrockenRules = etalonDict.Where(e => targetDict.ContainsKey(e.Key))
                                     .Where(e => JsonConvert.SerializeObject(targetDict[e.Key]) != JsonConvert.SerializeObject(e.Value))
                                     .Select(e => new CompareResult (e.Key, JsonConvert.SerializeObject(e.Value), JsonConvert.SerializeObject(targetDict[e.Key])))
                                     .ToList();

            if (etalonDict.Count > 0 && targetDict.Count > 0 && etalonDict.Where(e => targetDict.ContainsKey(e.Key)).Count() == 0)
            {
                throw new Exception("No properties to compare expected and actual objects");
            }

            return BrockenRules;
        }

        private void IterateProperties(object obj, Dictionary<string, object> dict, string parent = null, int count = 0)
        {
            if (obj == null) return;
            Type objType = obj.GetType();

            if (obj is string || objType.IsValueType)
            {
                var id = count > 0 ? $"_{count}" : "";
                dict.Add($"{parent}{id}", obj);
                return;
            }

            PropertyInfo[] properties = objType.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo property in properties)
            {
                object propValue = property.GetValue(obj, null);
                string propName = property.Name;

                if (propValue is IList elems)
                {
                    count = 1;
                    foreach (var item in elems)
                    {
                        IterateProperties(item, dict, propName, count);
                        count++;
                    }
                    count = 0;
                }
                else
                {
                    var delimiter = !string.IsNullOrEmpty(parent) ? "." : "";
                    var id = count > 0 ? $"_{count}" : "";

                    if (property.PropertyType.Assembly == objType.Assembly)
                    {
                        IterateProperties(propValue, dict, $"{parent}{id}{delimiter}{propName}");
                    }
                    else
                    {
                        if (propValue != null && IsDefaultValue(propValue) == false)
                        {
                            dict.Add($"{parent}{id}{delimiter}{propName}", propValue);
                        }
                    }
                }
            }
        }

        private bool IsDefaultValue(object obj)
        {
            var objType = obj.GetType();
            if (objType == typeof(bool))
            {
                return Equals(obj, default(bool));
            }
            if (objType == typeof(DateTime))
            {
                return Equals(obj, default(DateTime));
            }
            if (objType == typeof(int))
            {
                return Equals(obj, default(int));
            }

            return false;
        }

        #endregion Private Methods
    }
}