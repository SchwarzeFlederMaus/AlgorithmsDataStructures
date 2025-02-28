using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures.Queue;
using System;
using System.Collections.Generic;

namespace DataStructures.Tests.Queue
{
    [TestClass]
    public class MyQueueTests
    {
        [TestMethod]
        public void MyQueue_Constructor_ShouldInitializeEmptyQueue()
        {
            // Act
            var queue = new MyQueue<int>();

            // Assert
            Assert.IsTrue(queue.IsEmpty);
            Assert.AreEqual(0, queue.Count);
        }

        [TestMethod]
        public void MyQueue_ConstructorWithData_ShouldInitializeQueueWithOneElement()
        {
            // Arrange
            var data = 5;

            // Act
            var queue = new MyQueue<int>(data);

            // Assert
            Assert.IsFalse(queue.IsEmpty);
            Assert.AreEqual(1, queue.Count);
            Assert.AreEqual(data, queue.Peek());
        }

        [TestMethod]
        public void MyQueue_ConstructorWithCollection_ShouldInitializeQueueWithElements()
        {
            // Arrange
            var collection = new List<int> { 1, 2, 3 };

            // Act
            var queue = new MyQueue<int>(collection);

            // Assert
            Assert.AreEqual(collection.Count, queue.Count);
            Assert.AreEqual(collection[0], queue.Peek());
        }

        [TestMethod]
        public void Enqueue_ShouldAddElementToQueue()
        {
            // Arrange
            var queue = new MyQueue<int>();
            var data = 5;

            // Act
            queue.Enqueue(data);

            // Assert
            Assert.IsFalse(queue.IsEmpty);
            Assert.AreEqual(1, queue.Count);
            Assert.AreEqual(data, queue.Peek());
        }

        [TestMethod]
        public void Dequeue_ShouldRemoveAndReturnElementFromQueue()
        {
            // Arrange
            var queue = new MyQueue<int>(5);

            // Act
            var data = queue.Dequeue();

            // Assert
            Assert.AreEqual(5, data);
            Assert.IsTrue(queue.IsEmpty);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Peek_ShouldThrowException_WhenQueueIsEmpty()
        {
            // Arrange
            var queue = new MyQueue<int>();

            // Act
            queue.Peek();
        }

        [TestMethod]
        public void Peek_ShouldReturnFirstElementWithoutRemovingIt()
        {
            // Arrange
            var queue = new MyQueue<int>(5);

            // Act
            var data = queue.Peek();

            // Assert
            Assert.AreEqual(5, data);
            Assert.IsFalse(queue.IsEmpty);
        }

        [TestMethod]
        public void Clear_ShouldEmptyTheQueue()
        {
            // Arrange
            var queue = new MyQueue<int>(5);

            // Act
            queue.Clear();

            // Assert
            Assert.IsTrue(queue.IsEmpty);
            Assert.AreEqual(0, queue.Count);
        }
    }
}
