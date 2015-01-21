using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems;

namespace ProblemsTest
{
    [TestClass]
    public class Problem5Test
    {
        [TestMethod]
        public void Solve_20_232792560()
        {
            var problem = new Problem5(20);

            Assert.AreEqual(232792560, problem.Solve());
        }
    }
}
