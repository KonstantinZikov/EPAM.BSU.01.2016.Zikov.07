using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task4;
namespace Task4Tests
{
    [TestClass]
    public class SearchesTests
    {
        [TestMethod]
        public void ThreeElements()
        {
            var a = new[] { 1, 2, 3 };
            var result = Searches.BinarySearch(a,1);
            Assert.AreEqual(result,0);
        }

        [TestMethod]
        public void FourElements()
        {
            var a = new[] { 1, 2, 3 ,4};
            var result = Searches.BinarySearch(a, 4);
            Assert.AreEqual(result, 3);
        }

        [TestMethod]
        public void OneElement()
        {
            var a = new[] { 1 };
            var result = Searches.BinarySearch(a, 1);
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void NoElement()
        {
            var a = new[] { 1, 2, 3, 4 };
            var result = Searches.BinarySearch(a, 5);
            Assert.AreEqual(result, -1);
        }

        [TestMethod]
        public void MiddleElement()
        {
            var a = new[] { 1, 2, 3, 4,5 };
            var result = Searches.BinarySearch(a, 3);
            Assert.AreEqual(result, 2);
        }
    }
}
