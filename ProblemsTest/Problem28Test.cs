using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems;

namespace ProblemsTest
{
    [TestClass]
    public class Problem28Test
    {
        [TestMethod]
        public void Solve_Dimension1_1()
        {
            var problem = new Problem28(1);

            Assert.AreEqual(1, problem.Solve());
        }

        [TestMethod]
        public void Solve_Dimension3_25()
        {
            var problem = new Problem28(3);

            Assert.AreEqual(25, problem.Solve());
        }

        [TestMethod]
        public void Solve_Dimension5_101()
        {
            var problem = new Problem28(5);

            Assert.AreEqual(101, problem.Solve());
        }

        [TestMethod]
        public void Solve_Dimension1001_669171001()
        {
            var problem = new Problem28(1001);

            Assert.AreEqual(669171001, problem.Solve());
        }
    }
}
