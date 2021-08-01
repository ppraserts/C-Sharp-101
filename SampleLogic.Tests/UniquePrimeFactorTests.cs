using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace SampleLogic.Tests
{
    [TestFixture]
    public class UniquePrimeFactorTests
    {
        private static readonly object[] PrimeFactorNumbers = {
            new object[] { 30, new List<int> { 2, 3, 5 }},
            new object[] { 999999999, new List<int> { 3, 37, 333667 } }
        };

        [Test, TestCaseSource(nameof(PrimeFactorNumbers))]
        public void Should_Find_Unique_Prime_Factor_Number_When_Input_Number(int number, List<int> expectPrimeFactorNumbers)
        {
            // Act
            List<int> uniquePrimeFactorNumbers = NumberService.FindUniquePrimeFactor(number);

            // Assert
            Assert.AreEqual(expectPrimeFactorNumbers, uniquePrimeFactorNumbers);
        }
    }
}
