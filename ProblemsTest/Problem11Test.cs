using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems;

namespace ProblemsTest
{
    [TestClass]
    public class Problem11Test
    {
        [TestMethod]
        public void Solve_SmallGridWithValuesOnlyOnRow_CorrectResult()
        {
            var problem = new Problem11("02 03 04 05\n00 00 00 00\n00 00 00 00\n00 00 00 00", 4, 4);

            Assert.AreEqual(2 * 3 * 4 * 5, problem.Solve());
        }

        [TestMethod]
        public void Solve_SmallGridWithValuesOnlyOnColumn_CorrectResult()
        {
            var problem = new Problem11("02 00 00 00\n03 00 00 00\n04 00 00 00\n05 00 00 00", 4, 4);

            Assert.AreEqual(2 * 3 * 4 * 5, problem.Solve());
        }

        [TestMethod]
        public void Solve_SmallGridWithValuesOnlyOnMainDiagonal_CorrectResult()
        {
            var problem = new Problem11("02 00 00 00\n00 03 00 00\n00 00 04 00\n00 00 00 05", 4, 4);

            Assert.AreEqual(2*3*4*5, problem.Solve());
        }

        [TestMethod]
        public void Solve_SmallGridVersionTwo_CorrectResult()
        {
            var problem = new Problem11("02 08 00 00\n00 03 07 00\n00 00 04 09\n00 00 00 05", 4, 3);

            Assert.AreEqual(7*8*9, problem.Solve());
        }

        [TestMethod]
        public void Solve_SmallGridVersionThree_CorrectResult()
        {
            var problem = new Problem11("02 00 00 00\n07 03 00 00\n00 08 04 00\n00 00 09 05", 4, 3);

            Assert.AreEqual(7 * 8 * 9, problem.Solve());
        }

        [TestMethod]
        public void Solve_SmallGridVersionFour_CorrectResult()
        {
            var problem = new Problem11("00 00 07 05\n00 08 03 00\n09 04 00 00\n02 00 00 00", 4, 3);

            Assert.AreEqual(7 * 8 * 9, problem.Solve());
        }

        [TestMethod]
        public void Solve_SmallGridVersionFive_CorrectResult()
        {
            var problem = new Problem11("00 00 00 05\n00 00 03 08\n00 04 07 00\n02 09 00 00", 4, 3);

            Assert.AreEqual(7 * 8 * 9, problem.Solve());
        }

        [TestMethod]
        public void Solve_SmallGridWithValuesOnlyOnMinorDiagonal_CorrectResult()
        {
            var problem = new Problem11("00 00 00 05\n00 00 03 00\n00 04 00 00\n02 00 00 00", 4, 4);

            Assert.AreEqual(2 * 3 * 4 * 5, problem.Solve());
        }

        [TestMethod]
        public void Solve_SmallGrid_CorrectResult()
        {
            var problem = new Problem11("09 08 05\n02 01 03\n04 07 06", 3, 3);

            Assert.AreEqual(360, problem.Solve());
        }
    }
}
