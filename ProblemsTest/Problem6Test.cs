using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems;

namespace ProblemsTest
{
    [TestClass]
    public class Problem6Test
    {
        [TestMethod]
        public void Solve_UpperBorder10_2640()
        {
            var problem = new Problem6(10);

            Assert.AreEqual(2640, problem.Solve());
        }

        [TestMethod]
        public void Solve_UpperBorder100_25164150()
        {
            var problem = new Problem6(100);

            Assert.AreEqual(25164150, problem.Solve());
        }
    }
}
