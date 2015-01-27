using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems;

namespace ProblemsTest
{
    [TestClass]
    public class Problem24Test
    {
        [TestMethod]
        public void Solve_DigitCount3AndIndex1_12()
        {
            var problem = new Problem24(3, 1);

            Assert.AreEqual(12, problem.Solve());
        }

        [TestMethod]
        public void Solve_DigitCount3AndIndex2_21()
        {
            var problem = new Problem24(3, 2);

            Assert.AreEqual(21, problem.Solve());
        }

        [TestMethod]
        public void Solve_DigitCount3AndIndex3_102()
        {
            var problem = new Problem24(3, 3);

            Assert.AreEqual(102, problem.Solve());
        }

        [TestMethod]
        public void Solve_DigitCount3AndIndex4_120()
        {
            var problem = new Problem24(3, 4);

            Assert.AreEqual(120, problem.Solve());
        }

        [TestMethod]
        public void Solve_DigitCount3AndIndex5_201()
        {
            var problem = new Problem24(3, 5);

            Assert.AreEqual(201, problem.Solve());
        }

        [TestMethod]
        public void Solve_DigitCount3AndIndex6_210()
        {
            var problem = new Problem24(3, 6);

            Assert.AreEqual(210, problem.Solve());
        }

        [TestMethod]
        public void Solve_DigitCount10AndIndex1Million_CorrectResult()
        {
            var problem = new Problem24(10, 1000000);

            Assert.AreEqual(2783915460, problem.Solve());
        }
    }
}
