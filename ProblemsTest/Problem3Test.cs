using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems;

namespace Problem1Test
{
    [TestClass]
    public class Problem3Test
    {
        [TestMethod]
        public void Solve_NumberIs2_2()
        {
            var problem = new Problem3(2);

            Assert.AreEqual(2, problem.Solve());
        }

        [TestMethod]
        public void Solve_NumberIs23_23()
        {
            var problem = new Problem3(23);

            Assert.AreEqual(23, problem.Solve());
        }

        [TestMethod]
        public void Solve_NumberIs13195_29()
        {
            var problem = new Problem3(13195);

            Assert.AreEqual(29, problem.Solve());
        }

        [TestMethod]
        public void Solve_NumberIs600851475143_6857()
        {
            var problem = new Problem3(600851475143);

            Assert.AreEqual(6857, problem.Solve());
        }
    }
}
