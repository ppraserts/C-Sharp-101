using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleLogic
{
    public class NumberService
    {
        /// <summary>
        /// Is Prime Number หาจำนวนเฉพาะ
        /// </summary>
        /// <param name="primeNumber"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Find Factor Of Number หาตัวประกอบ
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static List<int> FindFactorOfNumber(int number)
        {
            var factorNumbers = new List<int>();
            for (int startNumber = 0; startNumber <= number; startNumber++)
            {
                if (startNumber != 0 && number % startNumber == 0)
                {
                    factorNumbers.Add(startNumber);
                }
            }
            return factorNumbers;
        }

        /// <summary>
        /// Find Unique Prime Factor หาตัวประกอบเฉพาะจากตัวเลข
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static List<int> FindUniquePrimeFactor(int number)
        {
            List<int> uniquePrimeFactorNumbers = new List<int>();

            // ----------------- Find Factor of Number -----------------
            List<int> factorNumbers = FindFactorOfNumber(number);

            foreach (var factorNumber in factorNumbers)
            {
                // ----------------- Find Prime of each Factor Number -----------------
                if (IsPrimeNumber(factorNumber))
                {
                    uniquePrimeFactorNumbers.Add(factorNumber);
                }
            }

            return uniquePrimeFactorNumbers;
        }
    }
}
