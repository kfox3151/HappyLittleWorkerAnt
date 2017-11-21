using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class NumberHelper
    {
        public static Random GenerateRandomNumber()
        {
            return new Random(Guid.NewGuid().GetHashCode());
        }

        public static int GenerateRandomNumberBetween(int rangeStart, int rangeEnd)
        {          
            return new Random(Guid.NewGuid().GetHashCode()).Next(rangeStart, rangeEnd);
        }
    }
}
