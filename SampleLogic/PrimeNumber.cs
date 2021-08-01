using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleLogic
{
    public class PrimeNumber
    {
        public static bool IsPrimeNumber(int primeNumber)
        {
            int count = 0;
            for (int startNumber = 1; startNumber <= primeNumber; startNumber++)
            {
                if (primeNumber % startNumber == 0)
                {
                    count++;
                }
            }

            return (count == 2);
        }
    }
}
