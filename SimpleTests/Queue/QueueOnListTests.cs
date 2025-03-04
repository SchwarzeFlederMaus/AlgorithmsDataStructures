using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures.Queue;
using System;
using System.Collections.Generic;

namespace Queue
{
    [TestClass]
    public class QueueOnListTests
    {
        [TestMethod]
        public void Enqueue_ShouldAddItemToQueue()
        {
            // Arrange
            var queue = new QueueOnList<int>();

            // Act
            queue.Enqueue(1);

            // Assert
            Assert.AreEqual(1, queue.Count);
            Assert.AreEqual(1, queue.Peek());
        }

        [TestMethod]
        public void Dequeue_ShouldRemoveAndReturnHeadItem()
        {
            // Arrange
            var queue = new QueueOnList<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);

            // Act
            var item = queue.Dequeue();

            // Assert
            Assert.AreEqual(1, item);
            Assert.AreEqual(1, queue.Count);
            Assert.AreEqual(2, queue.Peek());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Dequeue_ShouldThrowException_WhenQueueIsEmpty()
        {
            // Arrange
            var queue = new QueueOnList<int>();

            // Act
            queue.Dequeue();
        }

        [TestMethod]
        public void Peek_ShouldReturnHeadItemWithoutRemovingIt()
        {
            // Arrange
            var queue = new QueueOnList<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);

            // Act
            var item = queue.Peek();

            // Assert
            Assert.AreEqual(1, item);
            Assert.AreEqual(2, queue.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Peek_ShouldThrowException_WhenQueueIsEmpty()
        {
            // Arrange
            var queue = new QueueOnList<int>();

            // Act
            queue.Peek();
        }

        [TestMethod]
        public void Clear_ShouldRemoveAllItemsFromQueue()
        {
            // Arrange
            var queue = new QueueOnList<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);

            // Act
            queue.Clear();

            // Assert
            Assert.AreEqual(0, queue.Count);
            Assert.IsTrue(queue.IsEmpty);
        }

        [TestMethod]
        public void Constructor_ShouldInitializeQueueWithItems()
        {
            // Arrange
            var items = new List<int> { 1, 2, 3 };

            // Act
            var queue = new QueueOnList<int>(items);

            // Assert
            Assert.AreEqual(3, queue.Count);
            Assert.AreEqual(1, queue.Peek());
        }
    }
}
