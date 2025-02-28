using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures.Queue;
using System;

namespace DataStructures.Tests.Queue
{
    [TestClass]
    public class QueueOnArrayTests
    {
        [TestMethod]
        public void Enqueue_ShouldAddItemToQueue()
        {
            var queue = new QueueOnArray<int>(3);
            queue.Enqueue(1);
            Assert.AreEqual(1, queue.Peek());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Enqueue_ShouldThrowException_WhenQueueIsFull()
        {
            var queue = new QueueOnArray<int>(1);
            queue.Enqueue(1);
            queue.Enqueue(2); // This should throw an exception
        }

        [TestMethod]
        public void Dequeue_ShouldRemoveAndReturnItemFromQueue()
        {
            var queue = new QueueOnArray<int>(3);
            queue.Enqueue(1);
            queue.Enqueue(2);
            var item = queue.Dequeue();
            Assert.AreEqual(1, item);
            Assert.AreEqual(2, queue.Peek());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Dequeue_ShouldThrowException_WhenQueueIsEmpty()
        {
            var queue = new QueueOnArray<int>(3);
            queue.Dequeue(); // This should throw an exception
        }

        [TestMethod]
        public void Peek_ShouldReturnFirstItemWithoutRemovingIt()
        {
            var queue = new QueueOnArray<int>(3);
            queue.Enqueue(1);
            queue.Enqueue(2);
            var item = queue.Peek();
            Assert.AreEqual(1, item);
            Assert.AreEqual(1, queue.Peek()); // Ensure the item is not removed
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Peek_ShouldThrowException_WhenQueueIsEmpty()
        {
            var queue = new QueueOnArray<int>(3);
            queue.Peek(); // This should throw an exception
        }

        [TestMethod]
        public void IsEmpty_ShouldReturnTrue_WhenQueueIsEmpty()
        {
            var queue = new QueueOnArray<int>(3);
            Assert.IsTrue(queue.IsEmpty);
        }

        [TestMethod]
        public void IsEmpty_ShouldReturnFalse_WhenQueueIsNotEmpty()
        {
            var queue = new QueueOnArray<int>(3);
            queue.Enqueue(1);
            Assert.IsFalse(queue.IsEmpty);
        }

        [TestMethod]
        public void Capacity_ShouldReturnCorrectSize()
        {
            var queue = new QueueOnArray<int>(3);
            Assert.AreEqual(3, queue.Capacity);
        }
    }
}
