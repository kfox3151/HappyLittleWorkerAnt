using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HappyLittleWorkerAnt.Model
{
    public class DateGenerator
    {
        public static DateTime GetRandomDateInLastFiveYears()
        {   
                Random gen = new Random();
                int range = 5 * 365; //Past 5 years          
                DateTime randomDate = DateTime.Today.AddDays(-gen.Next(range));

                return randomDate;      
        }

        public static DateTime GetRandomDateBasedOnStartDate(DateTime startDate)
        {
            Random gen = new Random();
            int range = (DateTime.Today - startDate).Days;
            return startDate.AddDays(gen.Next(range));
        }
    }
}
