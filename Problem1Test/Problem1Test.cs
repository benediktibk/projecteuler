using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemsTest
{
    [TestClass]
    public class Problem1Test
    {
        [TestMethod]
        public void Solve_Limit10_23()
        {
            var problem = new Problems.Problem1(10);

            Assert.AreEqual(23, problem.Solve());
        }

        [TestMethod]
        public void Solve_Limit1000_233168()
        {
            var problem = new Problems.Problem1(1000);

            Assert.AreEqual(233168, problem.Solve());
        }
    }
}
