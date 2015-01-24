using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems;

namespace ProblemsTest
{
    [TestClass]
    public class Problem15Test
    {
        [TestMethod]
        public void Solve_Dimension2_6()
        {
            var problem = new Problem15(2);

            Assert.AreEqual(6, problem.Solve());
        }

        [TestMethod]
        public void Solve_Dimension4_70()
        {
            var problem = new Problem15(4);

            Assert.AreEqual(70, problem.Solve());
        }

        [TestMethod]
        public void Solve_Dimension6_924()
        {
            var problem = new Problem15(6);

            Assert.AreEqual(924, problem.Solve());
        }

        [TestMethod]
        public void Solve_Dimension8_12870()
        {
            var problem = new Problem15(8);

            Assert.AreEqual(12870, problem.Solve());
        }

        [TestMethod]
        public void Solve_Dimension10_184756()
        {
            var problem = new Problem15(10);

            Assert.AreEqual(184756, problem.Solve());
        }
    }
}
