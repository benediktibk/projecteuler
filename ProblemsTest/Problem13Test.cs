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

            Assert.AreEqual(3703703670, problem.Solve());
        }

        [TestMethod]
        public void Solve_ThriceTheSameNumberWithCarry_CorrectResult()
        {
            var problem = new Problem13("9234567890\n9234567890\n9234567890", 3, 10);

            Assert.AreEqual(2770370367, problem.Solve());
        }

        [TestMethod]
        public void Solve_TenTimesTheSameNumberWithCarry_CorrectResult()
        {
            var problem = new Problem13("9234567890\n9234567890\n9234567890\n9234567890\n9234567890\n9234567890\n9234567890\n9234567890\n9234567890\n9234567890", 10, 10);

            Assert.AreEqual(9234567890, problem.Solve());
        }

        [TestMethod]
        public void Solve_TwentyTimesTheSameNumberWithCarry_CorrectResult()
        {
            var problem = new Problem13("9234567890\n9234567890\n9234567890\n9234567890\n9234567890\n9234567890\n9234567890\n9234567890\n9234567890\n9234567890\n9234567890\n9234567890\n9234567890\n9234567890\n9234567890\n9234567890\n9234567890\n9234567890\n9234567890\n9234567890", 20, 10);

            Assert.AreEqual(1846913578, problem.Solve());
        }

        [TestMethod]
        public void Solve_Empty_5537376230()
        {
            var problem = new Problem13();

            Assert.AreEqual(5537376230, problem.Solve());
        }
    }
}
