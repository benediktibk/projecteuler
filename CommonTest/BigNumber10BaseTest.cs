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

            var result = a.Add(b);

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

            var result = b.Add(a);

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

            var result = a.Add(b);

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
    }
}
