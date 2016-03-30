using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task3;

namespace Task3Tests
{
    //TODO normal method names
    [TestClass]
    public class QueueTests
    {
        [TestMethod]
        public void Create()
        {
            //arrange
            //act
            var q = new Queue<int>();
            //assert
        }

        [TestMethod]
        public void CreateSize()
        {
            //arrange
            //act
            var q = new Queue<int>(41);
            //assert
        }

        [TestMethod]
        public void EnqueueDequeue()
        {
            //arrange
            var q = new Queue<int>(41);
            int firstElement = 5;
            int secondElement = 10;
            //act
            q.Enqueue(firstElement);
            q.Enqueue(secondElement);
            //assert
            Assert.AreEqual(firstElement, q.Dequeue());
            Assert.AreEqual(secondElement, q.Dequeue());
        }

        [TestMethod]
        public void EnqueueDequeueMany()
        {
            //arrange
            var q = new Queue<int>(8);
            int[] numbers = new[]
            {
                9,12,42,3,5,79,5,2,1,4,5,77
            };
            //act
            for (int i = 0; i < numbers.Length; i++)
            {
                q.Enqueue(numbers[i]);
            }
            //assert
            for (int i = 0; i < numbers.Length; i++)
            {
                Assert.AreEqual(numbers[i],q.Dequeue());
            }
        }

        [TestMethod]
        public void Peek()
        {
            //arrange
            var q = new Queue<int>(8);
            int number = 5;
            //act
            q.Enqueue(number);
            //assert
            Assert.AreEqual(number, q.Peek());
        }

        [TestMethod]
        public void Enumerator()
        {
            //arrange
            var q = new Queue<int>(8);
            int[] numbers = new[]
            {
                9,12,42,3,5,79,5,2,1,4,5,77
            };
            int i = 0;
            //act
            for (; i < numbers.Length; i++)
            {
                q.Enqueue(numbers[i]);
            }
            //assert
            i = 0;
            foreach(int el in q)
            {
                Assert.AreEqual(numbers[i++], el);
            }
        }
    }
}
