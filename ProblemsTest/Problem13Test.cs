using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems;

namespace ProblemsTest
{
    [TestClass]
    public class Problem13Test
    {
        [TestMethod]
        public void Solve_ThriceTheSameNumber_CorrectResult()
        {
            var problem = new Problem13("1234567890\n1234567890\n1234567890", 3, 10);

            Assert.AreEqual(3+7+3+7+3+6+7, problem.Solve());
        }

        [TestMethod]
        public void Solve_ThriceTheSameNumberWithCarry_CorrectResult()
        {
            var problem = new Problem13("9234567890\n9234567890\n9234567890", 3, 10);

            Assert.AreEqual(2 + 7 + 7 + 3 + 7 + 3 + 6 + 7, problem.Solve());
        }

        [TestMethod]
        public void Solve_TenTimesTheSameNumberWithCarry_CorrectResult()
        {
            var problem = new Problem13("9234567890\n9234567890\n9234567890\n9234567890\n9234567890\n9234567890\n9234567890\n9234567890\n9234567890\n9234567890", 10, 10);

            Assert.AreEqual(9 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9, problem.Solve());
        }

        [TestMethod]
        public void Solve_TwentyTimesTheSameNumberWithCarry_CorrectResult()
        {
            var problem = new Problem13("9234567890\n9234567890\n9234567890\n9234567890\n9234567890\n9234567890\n9234567890\n9234567890\n9234567890\n9234567890\n9234567890\n9234567890\n9234567890\n9234567890\n9234567890\n9234567890\n9234567890\n9234567890\n9234567890\n9234567890", 20, 10);

            Assert.AreEqual(1 + 8 + 4 + 6 + 9 + 1 + 3 + 5 + 7 + 8, problem.Solve());
        }
    }
}
