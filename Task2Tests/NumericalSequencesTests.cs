using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task2;

namespace Task2Tests
{
    [TestClass]
    public class NumericalSequencesTests
    {
        [TestMethod]
        public void Fibonacci_Seven_FirstSevenFibonacciNumbers()
        {
            //arrange
            int[] fib = new[] { 1, 1, 2, 3, 5, 8, 13 };
            int i = 0;
            //act
            //assert
            foreach(var num in NumericalSequences.Fibonacci(7))
            {
                Assert.AreEqual(fib[i++],num);
            }
        }
    }
}
