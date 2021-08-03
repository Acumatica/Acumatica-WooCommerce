using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace ACSC.Tests.Utils
{
    public static class Util
    {
        public static string Decrupt(this string s)
        {
            return Encoding.Unicode.GetString(Convert.FromBase64String(s));
        }

        public static List<string> Split(this string s)
        {
            if (!string.IsNullOrEmpty(s))
            {
                return s.Split(new[] { ' ' }).ToList();
            }

            return new List<string>();
        }

        public static Tuple<string,string> SplitToName(this string s)
        {
            var list = s.Split();
            var f = list.FirstOrDefault();
            var l = string.Join(" ", list.Skip(1));
            
            return new Tuple<string, string>(f, l);
        }

        public static string Concat(this string[] s, [CallerMemberName] string memberName = "")
        {
            if (s.Length == 2)
            {
                return $"{s[0]} {s[1]}";
            }
            throw new ArgumentException($"{memberName}: Array must contain two elements");
        }

        public static bool HasValue(this object obj)
        {
            return obj != null;
        }

        public static T Copy<T>(this object source)
        {
            var res = Activator.CreateInstance<T>();
            var props = res.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var sourceProps = source.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (var prop in props)
            {
                if (sourceProps.Any(p => p.Name == prop.Name))
                {
                    var value = prop.GetValue(source);
                    prop.SetValue(res, value);
                }
            }

            return res;
        }

        public static TResult IfNotNull<TInput, TResult>(this TInput o, Func<TInput, TResult> evaluator)
            where TResult : class where TInput : class
        {
            if (o == null) return null;
            return evaluator(o);
        }

    }
}