using System;
using System.Data.SqlTypes;
using System.Globalization;

namespace BCApiClient.Rest.ExtensionMethods
{
    public static class DateTimeExtensions
    {
        public static DateTime? StringToDateTime(this string value)
        {
            return DateTime.TryParse(value, CultureInfo.InvariantCulture.DateTimeFormat, DateTimeStyles.None, out var returnValue)
                ? returnValue as DateTime?
                : null;
        }

        public static string DateTimeToString(this DateTime? theDateTime)
        {
            return (theDateTime == (DateTime) SqlDateTime.MinValue || theDateTime == null)
                ? null
                : ((DateTime) theDateTime).ToUniversalTime().ToString("r");
        }


        public static string DateTimeToUnixTimeStampString(this DateTime? theDateTime)
        {
            return (theDateTime == (DateTime)SqlDateTime.MinValue || theDateTime == null)
                ? string.Empty
                : ((DateTimeOffset)((DateTime)theDateTime)).ToUnixTimeSeconds().ToString();
        }



    }
}
