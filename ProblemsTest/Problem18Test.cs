using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems;

namespace ProblemsTest
{
    [TestClass]
    public class Problem18Test
    {
        [TestMethod]
        public void Solve_ExampleTriangle_23()
        {
            var problem = new Problem18(Problem18.GetTriangleForExample());

            Assert.AreEqual(23, problem.Solve());
        }

        [TestMethod]
        public void Solve_Problem18Triangle_1074()
        {
            var problem = new Problem18(Problem18.GetTriangleForProblem18());

            Assert.AreEqual(1074, problem.Solve());
        }
    }
}
