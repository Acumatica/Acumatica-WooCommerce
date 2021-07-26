using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace ACSC.Tests.Cleanup
{
    public class CleanupHelper
    {
        private readonly string dir = Path.Combine(Environment.CurrentDirectory, subdir);
        private const string subdir = @"Cleanup";
        private const string fileName = @"SavedIDs.json";
        private readonly string fullPath;

        private SortedDictionary<string, List<ClenupEntity>> entities;

        public SortedDictionary<string, List<ClenupEntity>> Entities
        {
            get => entities ?? (entities = ReadEntities());
        }

        #region Singleton

        private CleanupHelper()
        {
            fullPath = Path.Combine(dir, fileName);
            CheckDataFile();
        }

        private static readonly Lazy<CleanupHelper> _helper = new Lazy<CleanupHelper>(() => new CleanupHelper());

        public static CleanupHelper Instance { get { return _helper.Value; } }

        #endregion Singleton

        public void Save(string typeName, List<ClenupEntity> entities)
        {
            if (Entities.ContainsKey(typeName))
            {
                Entities[typeName] = entities;
            }
            else
            {
                Entities.Add(typeName, entities);
            }

            Persist();
        }
        public void Save(string typeName, ClenupEntity entitity)
        {
            Save(typeName, new List<ClenupEntity>{ entitity });
        }

        public void Save(Type type, ClenupEntity entitity)
        {
            Save(type, new List<ClenupEntity>{ entitity });
        }

        public void Save(Type type, List<ClenupEntity> entities)
        {
            var typeName = type.Name;
            if (Entities.ContainsKey(typeName))
            {
                Entities[typeName] = entities;
            }
            else
            {
                Entities.Add(typeName, entities);
            }

            Persist();
        }

        public List<ClenupEntity> Get(Type type)
        {
            var name = type.Name;
            if (Entities.ContainsKey(name))
            {
                return Entities[name];
            }

            return new List<ClenupEntity>();
        }

        public List<ClenupEntity> Get(string name)
        {
            if (Entities.ContainsKey(name))
            {
                return Entities[name];
            }

            return new List<ClenupEntity>();
        }

        public bool Clean(Type type)
        {
            var name = type.Name;
            if (Entities.ContainsKey(name))
            {
                Entities[name].Clear();
                Persist();
                return true;
            }

            return false;
        }

        public bool Clean(string name)
        {
            if (Entities.ContainsKey(name))
            {
                Entities[name].Clear();
                Persist();
                return true;
            }
            return false;
        }

        private void CheckDataFile()
        {
            if (!File.Exists(fullPath))
            {
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                File.Create(fullPath).Close();
            }
        }

        private void Persist()
        {
            if (Entities != null)
            {
                var data = JsonConvert.SerializeObject(Entities);
                File.WriteAllText(fullPath, data);
            }
        }

        private SortedDictionary<string, List<ClenupEntity>> ReadEntities()
        {
            var data = File.ReadAllText(fullPath);
            if (!string.IsNullOrWhiteSpace(data))
            {
                return JsonConvert.DeserializeObject<SortedDictionary<string, List<ClenupEntity>>>(data);
            }

            return new SortedDictionary<string, List<ClenupEntity>>();
        }
    }

    public class ClenupEntity
    {
        public string Type { get; set; }
        public List<string> IDs { get; set; }

        public ClenupEntity()
        {
            IDs = new List<string>();
        }

        public ClenupEntity(Type type, string value) : this()
        {
            Type = type.Name;
            IDs.Add(value);
        }

        public ClenupEntity(Type type, List<string> value) : this()
        {
            Type = type.Name;
            IDs.AddRange(value);
        }
    }
}