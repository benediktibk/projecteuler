using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems;

namespace ProblemsTest
{
    [TestClass]
    public class Problem22Test
    {
        [TestMethod]
        public void Solve_Empty_CorrectResult()
        {
            var problem = new Problem22();

            Assert.AreEqual(-1, problem.Solve());
        }
    }
}
