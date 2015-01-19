using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Problem1Test
{
    [TestClass]
    public class Problem1Test
    {
        [TestMethod]
        public void Solve_10_23()
        {
            var problem = new Problem1.Problem1(10);

            Assert.AreEqual(23, problem.Solve());
        }
        [TestMethod]
        public void Solve_1000_233168()
        {
            var problem = new Problem1.Problem1(1000);

            Assert.AreEqual(233168, problem.Solve());
        }
    }
}
