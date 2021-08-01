using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace SampleLogic.Tests
{
    [TestFixture]
    public class FactorNumberTests
    {
        private static readonly object[] FactorNumbers = {
            new object[] { 12, new List<int> { 1, 2, 3, 4, 6, 12 }},
            new object[] { 30, new List<int> { 1, 2, 3, 5, 6, 10, 15, 30 }}
        };

        [Test, TestCaseSource(nameof(FactorNumbers))]
        public void Should_Find_Factor_Number_When_Input_Number(int number, List<int> expectFactorNumbers)
        {
            // Act
            List<int> factorNumbers = NumberService.FindFactorOfNumber(number);

            // Assert
            Assert.AreEqual(expectFactorNumbers, factorNumbers);
        }
    }
}
