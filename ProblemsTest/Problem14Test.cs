using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems;

namespace ProblemsTest
{
    [TestClass]
    public class Problem14Test
    {
        [TestMethod]
        public void CalculateSequenceLength_13_10()
        {
            var problem = new Problem14();

            Assert.AreEqual(10, problem.CalculateSequenceLength(13));
        }

        [TestMethod]
        public void Solve_Empty_CorrectResult()
        {
            var problem = new Problem14();

            Assert.AreEqual(1, problem.Solve());
        }
    }
}
