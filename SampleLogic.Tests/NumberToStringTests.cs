using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace SampleLogic.Tests
{
    [TestFixture]
    public class NumberToStringTests
    {
        private static readonly object[] ThaiNumberToEngNumber = {
            new object[] { "    ", "    "},
            new object[] { "๑      ๒", "1      2"},
            new object[] { "สวัสดี", "สวัสดี"},
            new object[] { "๑ ๒ ๓ ๔ ๕ ๖ ๗ ๘ ๙ ๐", "1 2 3 4 5 6 7 8 9 0" },
            new object[] { "๑   ๒ ๓ ๔    ๕ ๖ ๗ ๘ ๙    ๐", "1   2 3 4    5 6 7 8 9    0" },
            new object[] { "๑ ๒ ๓ ๔ ๕      ๖ ๗ ๘ ๙ ๐", "1 2 3 4 5      6 7 8 9 0" },
            new object[] { "๑,๒,๓,๔,๕,๖,๗,๘,๙,๐", "1,2,3,4,5,6,7,8,9,0" },
            new object[] { "๑๒๓,๔๕๖,๗๘๙.๐", "123,456,789.0" },
            new object[] { "๑๒๓,4๕6,789.๐", "123,456,789.0" },
            new object[] { "รวมเป็นเงินทั้งสิ้น ๑๒๓,๔๕๖,๗๘๙.๐ บาท", "รวมเป็นเงินทั้งสิ้น 123,456,789.0 บาท" },
            new object[] { "Total ๑๒๓,๔๕๖,๗๘๙.๐ Bath", "Total 123,456,789.0 Bath" },
            new object[] { "จำนวน ๑๒๓ ชิ้น รวมเป็นเงิน ๔๕๖,๗๘๙.๐ บาท", "จำนวน 123 ชิ้น รวมเป็นเงิน 456,789.0 บาท" },
        };

        private static readonly object[] EngNumberToThaiNumber = {
            new object[] { "", ""},
            new object[] { "1      2", "๑      ๒"},
            new object[] { "สวัสดี", "สวัสดี"},
            new object[] { "1 2 3 4 5 6 7 8 9 0", "๑ ๒ ๓ ๔ ๕ ๖ ๗ ๘ ๙ ๐" },
            new object[] { "1   2 3 4    5 6 7 8 9    0", "๑   ๒ ๓ ๔    ๕ ๖ ๗ ๘ ๙    ๐" },
            new object[] { "1 2 3 4 5      6 7 8 9 0", "๑ ๒ ๓ ๔ ๕      ๖ ๗ ๘ ๙ ๐" },
            new object[] { "1,2,3,4,5,6,7,8,9,0", "๑,๒,๓,๔,๕,๖,๗,๘,๙,๐" },
            new object[] { "123,456,789.0", "๑๒๓,๔๕๖,๗๘๙.๐" },
            new object[] { "123,๔5๖,๗๘๙.0", "๑๒๓,๔๕๖,๗๘๙.๐" },
            new object[] { "รวมเป็นเงินทั้งสิ้น 123,456,789.0 บาท", "รวมเป็นเงินทั้งสิ้น ๑๒๓,๔๕๖,๗๘๙.๐ บาท" },
            new object[] { "Total 123,456,789.0 Bath", "Total ๑๒๓,๔๕๖,๗๘๙.๐ Bath" },
            new object[] { "จำนวน 123 ชิ้น รวมเป็นเงิน 456,789.0 บาท", "จำนวน ๑๒๓ ชิ้น รวมเป็นเงิน ๔๕๖,๗๘๙.๐ บาท" },
        };

        [Test, TestCaseSource(nameof(ThaiNumberToEngNumber))]
        public void Should_Return_Number_In_Eng_String_When_Input_Number_In_Thai(string inputNumber, string expectNumber)
        {
            var convertType = ConvertNumberToStringEnum.ThaiNumberToEngNumber;
            var result = NumberService.NumberToString(inputNumber, convertType);
            Assert.AreEqual(expectNumber, result);
        }

        [Test, TestCaseSource(nameof(EngNumberToThaiNumber))]
        public void Should_Return_Number_In_Thai_String_When_Input_Number_In_Eng(string inputNumber, string expectNumber)
        {
            var convertType = ConvertNumberToStringEnum.EngNumberToThaiNumber;
            var result = NumberService.NumberToString(inputNumber, convertType);
            Assert.AreEqual(expectNumber, result);
        }
    }
}
