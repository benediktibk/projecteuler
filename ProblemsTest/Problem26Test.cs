using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems;

namespace ProblemsTest
{
    [TestClass]
    public class Problem26Test
    {
        [TestMethod]
        public void CalculatePeriodLength_2_0()
        {
            Assert.AreEqual(0, Problem26.CalculatePeriodLength(2));
        }

        [TestMethod]
        public void CalculatePeriodLength_3_1()
        {
            Assert.AreEqual(1, Problem26.CalculatePeriodLength(3));
        }

        [TestMethod]
        public void CalculatePeriodLength_4_0()
        {
            Assert.AreEqual(0, Problem26.CalculatePeriodLength(4));
        }

        [TestMethod]
        public void CalculatePeriodLength_5_0()
        {
            Assert.AreEqual(0, Problem26.CalculatePeriodLength(5));
        }

        [TestMethod]
        public void CalculatePeriodLength_6_1()
        {
            Assert.AreEqual(1, Problem26.CalculatePeriodLength(6));
        }

        [TestMethod]
        public void CalculatePeriodLength_7_6()
        {
            Assert.AreEqual(6, Problem26.CalculatePeriodLength(7));
        }

        [TestMethod]
        public void CalculatePeriodLength_8_0()
        {
            Assert.AreEqual(0, Problem26.CalculatePeriodLength(8));
        }

        [TestMethod]
        public void CalculatePeriodLength_9_1()
        {
            Assert.AreEqual(1, Problem26.CalculatePeriodLength(9));
        }

        [TestMethod]
        public void CalculatePeriodLength_10_0()
        {
            Assert.AreEqual(0, Problem26.CalculatePeriodLength(10));
        }
        
        [TestMethod]
        public void Solve_DenominatorLimit11_7()
        {
            var problem = new Problem26(11);

            Assert.AreEqual(7, problem.Solve());
        }

        [TestMethod]
        public void Solve_DenominatorLimit1000_983()
        {
            var problem = new Problem26(1000);

            Assert.AreEqual(983, problem.Solve());
        }
    }
}
