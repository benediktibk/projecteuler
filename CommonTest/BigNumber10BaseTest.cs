using System.Collections.Generic;
using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CommonTest
{
    [TestClass]
    public class BigNumber10BaseTest
    {
        [TestMethod]
        public void Constructor_12345_Digits12345()
        {
            var number = new BigNumber10Base(12345);

            Assert.AreEqual(5, number.DigitCount);
            Assert.AreEqual((uint)5, number[0]);
            Assert.AreEqual((uint)4, number[1]);
            Assert.AreEqual((uint)3, number[2]);
            Assert.AreEqual((uint)2, number[3]);
            Assert.AreEqual((uint)1, number[4]);
        }

        [TestMethod]
        public void Add_12345And789_Digits13134()
        {
            var a = new BigNumber10Base(12345);
            var b = new BigNumber10Base(789);

            var result = BigNumber10Base.Add(a, b);

            Assert.AreEqual(5, result.DigitCount);
            Assert.AreEqual((uint)4, result[0]);
            Assert.AreEqual((uint)3, result[1]);
            Assert.AreEqual((uint)1, result[2]);
            Assert.AreEqual((uint)3, result[3]);
            Assert.AreEqual((uint)1, result[4]);
        }

        [TestMethod]
        public void Add_789And12345_Digits13134()
        {
            var a = new BigNumber10Base(12345);
            var b = new BigNumber10Base(789);

            var result = BigNumber10Base.Add(a, b);

            Assert.AreEqual(5, result.DigitCount);
            Assert.AreEqual((uint)4, result[0]);
            Assert.AreEqual((uint)3, result[1]);
            Assert.AreEqual((uint)1, result[2]);
            Assert.AreEqual((uint)3, result[3]);
            Assert.AreEqual((uint)1, result[4]);
        }

        [TestMethod]
        public void Add_999And789_Digits1788()
        {
            var a = new BigNumber10Base(999);
            var b = new BigNumber10Base(789);

            var result = BigNumber10Base.Add(a, b);

            Assert.AreEqual(4, result.DigitCount);
            Assert.AreEqual((uint)8, result[0]);
            Assert.AreEqual((uint)8, result[1]);
            Assert.AreEqual((uint)7, result[2]);
            Assert.AreEqual((uint)1, result[3]);
        }

        [TestMethod]
        public void ShiftLeft_123By2_Digits12300()
        {
            var number = new BigNumber10Base(123);

            var result = number.ShiftLeft(2);

            Assert.AreEqual(5, result.DigitCount);
            Assert.AreEqual((uint)0, result[0]);
            Assert.AreEqual((uint)0, result[1]);
            Assert.AreEqual((uint)3, result[2]);
            Assert.AreEqual((uint)2, result[3]);
            Assert.AreEqual((uint)1, result[4]);
        }

        [TestMethod]
        public void Multiply_123And9_Digits1107()
        {
            var a = new BigNumber10Base(123);
            var b = new BigNumber10Base(9);

            var result = BigNumber10Base.Multiply(a, b);

            Assert.AreEqual(4, result.DigitCount);
            Assert.AreEqual((uint)7, result[0]);
            Assert.AreEqual((uint)0, result[1]);
            Assert.AreEqual((uint)1, result[2]);
            Assert.AreEqual((uint)1, result[3]);
        }

        [TestMethod]
        public void Multiply_123And4366_Digits537018()
        {
            var a = new BigNumber10Base(123);
            var b = new BigNumber10Base(4366);

            var result = BigNumber10Base.Multiply(a, b);

            Assert.AreEqual(6, result.DigitCount);
            Assert.AreEqual((uint)8, result[0]);
            Assert.AreEqual((uint)1, result[1]);
            Assert.AreEqual((uint)0, result[2]);
            Assert.AreEqual((uint)7, result[3]);
            Assert.AreEqual((uint)3, result[4]);
            Assert.AreEqual((uint)5, result[5]);
        }

        [TestMethod]
        public void Convert_BigNumberInt32Base_CorrectDigits()
        {
            var source = new BigNumberInt32Base((((ulong)1) << 60) - 1);

            var result = BigNumber10Base.Convert(source);

            var digitsShouldBe = new List<ulong> { 1, 1, 5, 2, 9, 2, 1, 5, 0, 4, 6, 0, 6, 8, 4, 6, 9, 7, 5 };
            digitsShouldBe.Reverse();
            Assert.AreEqual(digitsShouldBe.Count, result.DigitCount);

            for (var i = 0; i < digitsShouldBe.Count; ++i)
                Assert.AreEqual(digitsShouldBe[i], result[i]);
        }

        [TestMethod]
        public void Convert_23AsBigNumberInt32Base_CorrectDigits()
        {
            var source = new BigNumberInt32Base(23);

            var result = BigNumber10Base.Convert(source);

            Assert.AreEqual(2, result.DigitCount);
            Assert.AreEqual((uint)3, result[0]);
            Assert.AreEqual((uint)2, result[1]);
        }

        [TestMethod]
        public void Convert_23456AsBigNumberInt32Base_CorrectDigits()
        {
            var source = new BigNumberInt32Base(23456);

            var result = BigNumber10Base.Convert(source);

            Assert.AreEqual(5, result.DigitCount);
            Assert.AreEqual((uint)6, result[0]);
            Assert.AreEqual((uint)5, result[1]);
            Assert.AreEqual((uint)4, result[2]);
            Assert.AreEqual((uint)3, result[3]);
            Assert.AreEqual((uint)2, result[4]);
        }
    }
}
