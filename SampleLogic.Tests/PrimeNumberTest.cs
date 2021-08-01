using NUnit.Framework;
using System;

namespace SampleLogic.Tests
{
    [TestFixture]
    public class PrimeNumberTest
    {
        static int[] PrimeNumbers = new int[] { 2, 3, 5, 7, 11, 13, 17, 19 };
        static int[] WrongPrimeNumbers = new int[] { 0, 1, 4, 6, 8, 9, 10, 12, 14, 15, 16, 18, 20 };

        [Test, TestCaseSource(nameof(PrimeNumbers))]
        public void Should_Valid_When_Input_Prime_Number(int primeNumber)
        {
            // Act
            bool result = NumberService.IsPrimeNumber(primeNumber);

            // Assert
            Assert.IsTrue(result);
        }

        [Test, TestCaseSource(nameof(WrongPrimeNumbers))]
        public void Should_Invalid_When_Input_Wrong_Prime_Number(int wrongPrimeNumber)
        {
            // Act
            bool result = NumberService.IsPrimeNumber(wrongPrimeNumber);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
