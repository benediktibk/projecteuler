using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems;

namespace ProblemsTest
{
    [TestClass]
    public class Problem9Test
    {
        [TestMethod]
        public void Solve_Empty_31875000()
        {
            var problem = new Problem9();

            Assert.AreEqual(31875000, problem.Solve());
        }
    }
}
