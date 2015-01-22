using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems;

namespace ProblemsTest
{
    [TestClass]
    public class Problem8Test
    {
        [TestMethod]
        public void Solve_Length4_5832()
        {
            var problem = new Problem8(4);

            Assert.AreEqual(5832, problem.Solve());
        }

        [TestMethod]
        public void Solve_Length2_81()
        {
            var problem = new Problem8(2);

            Assert.AreEqual(81, problem.Solve());
        }

        [TestMethod]
        public void Solve_Length3_648()
        {
            var problem = new Problem8(3);

            Assert.AreEqual(648, problem.Solve());
        }

        [TestMethod]
        public void Solve_Length13_23514624000()
        {
            var problem = new Problem8(13);

            Assert.AreEqual(23514624000, problem.Solve());
        }
    }
}
