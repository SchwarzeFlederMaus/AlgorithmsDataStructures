using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using DataStructures.Queue;

namespace DataStructures.Tests.Queue
{
    [TestClass]
    public class MyDequeTests
    {
        [TestMethod]
        public void Constructor_ShouldInitializeEmptyDeque()
        {
            // Act
            var deque = new MyDeque<int>();

            // Assert
            Assert.IsTrue(deque.IsEmpty);
            Assert.AreEqual(0, deque.Count);
        }

        [TestMethod]
        public void Constructor_WithData_ShouldInitializeDequeWithOneElement()
        {
            // Arrange
            var data = 5;

            // Act
            var deque = new MyDeque<int>(data);

            // Assert
            Assert.IsFalse(deque.IsEmpty);
            Assert.AreEqual(1, deque.Count);
            Assert.AreEqual(data, deque.PeekHead());
        }

        [TestMethod]
        public void Constructor_WithCollection_ShouldInitializeDequeWithElements()
        {
            // Arrange
            var collection = new List<int> { 1, 2, 3 };

            // Act
            var deque = new MyDeque<int>(collection);

            // Assert
            Assert.AreEqual(collection.Count, deque.Count);
            Assert.AreEqual(1, deque.PeekHead());
            Assert.AreEqual(3, deque.PeekTail());
        }

        [TestMethod]
        public void EnqueueTail_ShouldAddElementToEnd()
        {
            // Arrange
            var deque = new MyDeque<int>();
            var data = 5;

            // Act
            deque.EnqueueTail(data);

            // Assert
            Assert.AreEqual(1, deque.Count);
            Assert.AreEqual(data, deque.PeekTail());
        }

        [TestMethod]
        public void EnqueueHead_ShouldAddElementToFront()
        {
            // Arrange
            var deque = new MyDeque<int>();
            var data = 5;

            // Act
            deque.EnqueueHead(data);

            // Assert
            Assert.AreEqual(1, deque.Count);
            Assert.AreEqual(data, deque.PeekHead());
        }

        [TestMethod]
        public void DequeueTail_ShouldRemoveAndReturnElementFromEnd()
        {
            // Arrange
            var deque = new MyDeque<int>(new List<int> { 1, 2, 3 });

            // Act
            var result = deque.DequeueTail();

            // Assert
            Assert.AreEqual(3, result);
            Assert.AreEqual(2, deque.Count);
        }

        [TestMethod]
        public void DequeueHead_ShouldRemoveAndReturnElementFromFront()
        {
            // Arrange
            var deque = new MyDeque<int>(new List<int> { 1, 2, 3 });

            // Act
            var result = deque.DequeueHead();

            // Assert
            Assert.AreEqual(1, result);
            Assert.AreEqual(2, deque.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void PeekTail_ShouldThrowExceptionIfDequeIsEmpty()
        {
            // Arrange
            var deque = new MyDeque<int>();

            // Act
            deque.PeekTail();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void PeekHead_ShouldThrowExceptionIfDequeIsEmpty()
        {
            // Arrange
            var deque = new MyDeque<int>();

            // Act
            deque.PeekHead();
        }

        [TestMethod]
        public void Clear_ShouldRemoveAllElements()
        {
            // Arrange
            var deque = new MyDeque<int>(new List<int> { 1, 2, 3 });

            // Act
            deque.Clear();

            // Assert
            Assert.IsTrue(deque.IsEmpty);
            Assert.AreEqual(0, deque.Count);
        }
    }
}
