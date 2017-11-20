using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class NumberHelper
    {
        public static int GenerateRandomNumberBetween(int rangeStart, int rangeEnd)
        {          
            return new Random().Next(rangeStart, rangeEnd);
        }
    }
}
