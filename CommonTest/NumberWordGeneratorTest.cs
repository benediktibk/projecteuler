using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CommonTest
{
    [TestClass]
    public class NumberWordGeneratorTest
    {
        private NumberWordGenerator _numberWordGenerator;

        [TestInitialize]
        public void SetUp()
        {
            _numberWordGenerator = new NumberWordGenerator();
        }

        [TestMethod]
        public void Indexer_22_CorrectResult()
        {
            Assert.AreEqual("twenty-two", _numberWordGenerator[22]);
        }

        [TestMethod]
        public void Indexer_114_CorrectResult()
        {
            Assert.AreEqual("one hundred and fourteen", _numberWordGenerator[114]);
        }

        [TestMethod]
        public void Indexer_133_CorrectResult()
        {
            Assert.AreEqual("one hundred and thirty-three", _numberWordGenerator[133]);
        }

        [TestMethod]
        public void Indexer_1000_CorrectResult()
        {
            Assert.AreEqual("one thousand", _numberWordGenerator[1000]);
        }
    }
}
