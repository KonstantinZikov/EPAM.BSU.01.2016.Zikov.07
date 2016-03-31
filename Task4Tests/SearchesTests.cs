using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task4;

namespace Task4Tests
{
    [TestClass]
    public class SearchesTests
    {
        [TestMethod]
        public void BinarySearch_ThreeNumbers_IndexOfFirst()
        {
            //arrange
            var a = new[] { 1, 2, 3 };
            //act
            var result = Searches.BinarySearch(a, 1);
            //assert
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void BinarySearch_FourNumbers_IndexOfLast()
        {
            //arrange
            var a = new[] { 1, 2, 3 ,4};
            //act
            var result = Searches.BinarySearch(a, 4);
            //assert
            Assert.AreEqual(result, 3);
        }

        [TestMethod]
        public void BinarySearch_OneNumber_NumberIndex()
        {
            //arrange
            var a = new[] { 1 };
            //act
            var result = Searches.BinarySearch(a, 1);
            //assert
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void BinarySearch_FourNumbersAndNumberOutOfSet_MinusOne()
        {
            //arrange
            var a = new[] { 1, 2, 3, 4 };
            //act
            var result = Searches.BinarySearch(a, 5);
            //assert
            Assert.AreEqual(result, -1);
        }

        [TestMethod]
        public void BinarySearch_FiveElements_IndexOfMiddleElement()
        {
            //arrange
            var a = new[] { 1, 2, 3, 4, 5 };
            //act
            var result = Searches.BinarySearch(a, 3);
            //assert
            Assert.AreEqual(result, 2);
        }
    }
}
