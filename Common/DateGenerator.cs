using System;

namespace Common
{
    public class DateGenerator
    {
        public static DateTime GetRandomDateInLastFiveYears()
        {   
                const int range = 5 * 365;          
                return DateTime.Today.AddDays(NumberHelper.GenerateRandomNumber().Next(range));     
        }

        public static DateTime GetRandomDateBasedOnStartDate(DateTime startDate)
        {
            var range = (DateTime.Today - startDate).Days;
            return startDate.AddDays(NumberHelper.GenerateRandomNumber().Next(range));
        }
    }
}
