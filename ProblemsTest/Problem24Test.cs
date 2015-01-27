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
    }
}
