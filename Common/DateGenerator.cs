using System;

namespace Common
{
    public class DateGenerator
    {
        public static DateTime GetRandomDateInLastFiveYears()
        {   
                const int range = 5 * 365;          
                return DateTime.Today.AddDays(NumberHelper.GenerateRandomNumber().Next(range)*(-1));     
        }

        public static DateTime? GetRandomDateBasedOnStartDate(DateTime? startDate)
        {
            if (startDate == null) return null;
            var rangeStart = startDate.Value;
            var range = (DateTime.Today - rangeStart).Days;
            return rangeStart.AddDays(NumberHelper.GenerateRandomNumber().Next(range));
        }
    }
}
