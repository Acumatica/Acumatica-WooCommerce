using System;
using System.Collections.Generic;

namespace ACSC.Tests.PageVisitors
{
    public static class VisitorsManager
    {
        public static List<T> Get<T>(object location, params Type[] visitorTypes)
        {
            var list = new List<T>();
            foreach (var visitorType in visitorTypes)
            {
                list.Add(Get<T>(visitorType, location));
            }

            return list;
        }

        public static T GetSingle<T>(object location, Type visitorType)
        {
            return Get<T>(visitorType, location);
        }

        public static T GetSingle<T>(Type visitorType)
        {
            return Get<T>(visitorType);
        }

        private static T Get<T>(Type visitorType, params object[] parameters)
        {
            var obj = Activator.CreateInstance(visitorType, parameters);
            if (obj is T visitor)
            {
                return visitor;
            }
            throw new TypeLoadException();
        }                
    }
}