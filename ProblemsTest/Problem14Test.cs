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
        public void CalculateSequenceLength_TwiceCalledWith13_10()
        {
            var problem = new Problem14();

            problem.CalculateSequenceLength(13);

            Assert.AreEqual(10, problem.CalculateSequenceLength(13));
        }

        [TestMethod]
        public void CalculateSequenceLength_ThriceCalledWithDifferentValues_CorrectResult()
        {
            var problem = new Problem14();

            Assert.AreEqual(7, problem.CalculateSequenceLength(10));
            Assert.AreEqual(5, problem.CalculateSequenceLength(16));
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
