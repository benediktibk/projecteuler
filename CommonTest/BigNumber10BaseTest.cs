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

            Assert.AreEqual((uint)5, number[0]);
            Assert.AreEqual((uint)4, number[1]);
            Assert.AreEqual((uint)3, number[2]);
            Assert.AreEqual((uint)2, number[3]);
            Assert.AreEqual((uint)1, number[4]);
        }
    }
}
