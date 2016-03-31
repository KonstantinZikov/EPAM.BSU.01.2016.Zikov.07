using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task5;
namespace Task5Tests
{
    [TestClass]
    public class SortsTests
    {
        [TestMethod]
        public void QuickSort_10000OfRandomNumbers_EveryNumberIsLessThenNext()
        {
            // arrange
            Random rand = new Random(42);
            var array = new int[10000];
            for (int i = 0; i < 10000; i++)
            {
                array[i] = rand.Next();
            }

            // act
            array.QuickSort();

            // assert
            for (int i = 0; i < 9999; i++)
            {
                Assert.IsTrue(array[i] <= array[i + 1]);
            }
        }
       
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void QuickSort_null_ArgumentNullException()
        {
            // arrange is skiped
            // act
            Sorts.QuickSort<int>(null);
            // assert is handled by exception
        }

    }
}
