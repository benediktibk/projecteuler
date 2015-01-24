using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems;

namespace ProblemsTest
{
    [TestClass]
    public class Problem17Test
    {
        private NumberWordGenerator _numberWordGenerator;

        [TestInitialize]
        public void SetUp()
        {
            _numberWordGenerator = new NumberWordGenerator();
        }

        [TestMethod]
        public void Solve_Limit5_19()
        {
            var problem = new Problem17(5, _numberWordGenerator);

            Assert.AreEqual(19, problem.Solve());
        }
    }
}
