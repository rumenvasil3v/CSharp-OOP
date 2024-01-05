using System.Globalization;

namespace LogForMe.ConsoleApp.Utils
{
    public static class DateTimeValidator
    {
        private static ISet<string> validDateFormats = 
            new HashSet<string>() { "M/dd/yyyy h:mm:ss tt" };

        public static void AddDateTimeFormat(string format)
        {
            validDateFormats.Add(format);
        } 
         
        internal static bool ValidateDateTimeFormats(string dateTimeFormat)
        {
            foreach (var format in validDateFormats)
            {
                if (DateTime.TryParseExact(dateTimeFormat, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime result))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
