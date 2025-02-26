using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures.Stack;
using System;
using System.Collections.Generic;

namespace DataStructures.Tests.Stack
{
    [TestClass]
    public class MyStackTests
    {
        [TestMethod]
        public void Constructor_ShouldInitializeEmptyStack()
        {
            // Act
            var stack = new MyStack<int>();

            // Assert
            Assert.IsTrue(stack.IsEmpty);
            Assert.AreEqual(0, stack.Count);
        }

        [TestMethod]
        public void Constructor_ShouldInitializeStackWithSingleElement()
        {
            // Arrange
            int expectedData = 5;

            // Act
            var stack = new MyStack<int>(expectedData);

            // Assert
            Assert.IsFalse(stack.IsEmpty);
            Assert.AreEqual(1, stack.Count);
            Assert.AreEqual(expectedData, stack.Peek());
        }

        [TestMethod]
        public void Constructor_ShouldInitializeStackWithCollection()
        {
            // Arrange
            var collection = new List<int> { 1, 2, 3 };

            // Act
            var stack = new MyStack<int>(collection);

            // Assert
            Assert.IsFalse(stack.IsEmpty);
            Assert.AreEqual(collection.Count, stack.Count);
            Assert.AreEqual(collection[^1], stack.Peek());
        }

        [TestMethod]
        public void Push_ShouldAddElementToStack()
        {
            // Arrange
            var stack = new MyStack<int>();
            int expectedData = 10;

            // Act
            stack.Push(expectedData);

            // Assert
            Assert.IsFalse(stack.IsEmpty);
            Assert.AreEqual(1, stack.Count);
            Assert.AreEqual(expectedData, stack.Peek());
        }

        [TestMethod]
        public void Pop_ShouldRemoveAndReturnTopElement()
        {
            // Arrange
            var stack = new MyStack<int>();
            stack.Push(1);
            stack.Push(2);
            int expectedData = 2;

            // Act
            var result = stack.Pop();

            // Assert
            Assert.AreEqual(expectedData, result);
            Assert.AreEqual(1, stack.Count);
            Assert.AreEqual(1, stack.Peek());
        }

        [TestMethod]
        [ExpectedException(typeof(StackOverflowException))]
        public void Pop_ShouldThrowExceptionWhenStackIsEmpty()
        {
            // Arrange
            var stack = new MyStack<int>();

            // Act
            stack.Pop();
        }

        [TestMethod]
        public void Peek_ShouldReturnTopElementWithoutRemovingIt()
        {
            // Arrange
            var stack = new MyStack<int>();
            stack.Push(1);
            stack.Push(2);
            int expectedData = 2;

            // Act
            var result = stack.Peek();

            // Assert
            Assert.AreEqual(expectedData, result);
            Assert.AreEqual(2, stack.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(StackOverflowException))]
        public void Peek_ShouldThrowExceptionWhenStackIsEmpty()
        {
            // Arrange
            var stack = new MyStack<int>();

            // Act
            stack.Peek();
        }
    }
}
