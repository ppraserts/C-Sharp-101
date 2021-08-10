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

        public static string NumberToString(string inputNumber, ConvertNumberToStringEnum convertType)
        {
            string result = string.Empty;
            string pattern = string.Empty;
            if (string.IsNullOrEmpty(inputNumber))
            {
                return result;
            }

            string[] arabicNumber = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string[] thaiNumber = new string[] { "๐", "๑", "๒", "๓", "๔", "๕", "๖", "๗", "๘", "๙" };
            string[] fromNumber = null;
            string[] toNumber = null;

            if (convertType == ConvertNumberToStringEnum.ThaiNumberToEngNumber)
            {
                fromNumber = thaiNumber;
                toNumber = arabicNumber;
            }
            else
            {
                fromNumber = arabicNumber;
                toNumber = thaiNumber;
            }

            char space = (char)32;
            for (int i = 0; i < inputNumber.Length; i++)
            {
                var currentChar = inputNumber[i];
                var index = Array.IndexOf(fromNumber, currentChar.ToString());
                if (index == -1 && currentChar == space)
                {
                    result = result + " ";
                }
                else if (index == -1 && currentChar != space)
                {
                    result = result + currentChar.ToString();
                }
                else
                {
                    result = result + toNumber[index];
                }
            }

            return result;
        }
    }
}
