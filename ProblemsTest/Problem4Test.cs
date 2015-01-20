using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems;

namespace ProblemsTest
{
    [TestClass]
    public class Problem4Test
    {
        private Problem4 _problem;

        [TestInitialize]
        public void SetUp()
        {
            _problem = new Problem4(2);
        }

        [TestMethod]
        public void IsPalindrome_3456_false()
        {
            Assert.IsFalse(_problem.IsPalindrome(3456));
        }

        [TestMethod]
        public void IsPalindrome_3443_true()
        {
            Assert.IsTrue(_problem.IsPalindrome(3443));
        }

        [TestMethod]
        public void IsPalindrome_34543_true()
        {
            Assert.IsTrue(_problem.IsPalindrome(34543));
        }

        [TestMethod]
        public void ExtractDigit_3456And1_6()
        {
            Assert.AreEqual(6, _problem.ExtractDigit(3456, 1));
        }

        [TestMethod]
        public void ExtractDigit_3456And2_5()
        {
            Assert.AreEqual(5, _problem.ExtractDigit(3456, 2));
        }

        [TestMethod]
        public void ExtractDigit_3456And3_4()
        {
            Assert.AreEqual(4, _problem.ExtractDigit(3456, 3));
        }

        [TestMethod]
        public void ExtractDigit_3456And4_3()
        {
            Assert.AreEqual(3, _problem.ExtractDigit(3456, 4));
        }

        [TestMethod]
        public void Solve_2Digits_9009()
        {
            Assert.AreEqual(9009, _problem.Solve());
        }

        [TestMethod]
        public void Solve_3Digits_906609()
        {
            _problem = new Problem4(3);

            Assert.AreEqual(906609, _problem.Solve());
        }
    }
}
