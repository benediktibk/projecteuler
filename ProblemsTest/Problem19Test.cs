using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems;

namespace ProblemsTest
{
    [TestClass]
    public class Problem19Test
    {
        [TestMethod]
        public void Solve_Empty_171()
        {
            var problem = new Problem19();

            Assert.AreEqual(171, problem.Solve());
        }
    }
}
