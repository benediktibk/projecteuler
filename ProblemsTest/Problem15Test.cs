using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems;

namespace ProblemsTest
{
    [TestClass]
    public class Problem15Test
    {
        [TestMethod]
        public void Solve_Dimension2_6()
        {
            var problem = new Problem15(2);

            Assert.AreEqual(6, problem.Solve());
        }
    }
}
