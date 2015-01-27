using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CommonTest
{
    [TestClass]
    public class CombinatorialTest
    {
        [TestMethod]
        public void Factorial_0_1()
        {
            Assert.AreEqual(1, Combinatorial.Factorial(0));
        }

        [TestMethod]
        public void Factorial_1_1()
        {
            Assert.AreEqual(1, Combinatorial.Factorial(1));
        }

        [TestMethod]
        public void Factorial_3_6()
        {
            Assert.AreEqual(6, Combinatorial.Factorial(3));
        }

        [TestMethod]
        public void Factorial_10_3628800()
        {
            Assert.AreEqual(3628800, Combinatorial.Factorial(10));
        }
    }
}
