using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems;

namespace ProblemsTest
{
    [TestClass]
    public class Problem25Test
    {
        [TestMethod]
        public void Solve_3Digits_12()
        {
            var problem = new Problem25(3);

            Assert.AreEqual(12, problem.Solve());
        }

        [TestMethod]
        public void Solve_1000Digits_4782()
        {
            var problem = new Problem25(1000);

            Assert.AreEqual(4782, problem.Solve());
        }
    }
}
