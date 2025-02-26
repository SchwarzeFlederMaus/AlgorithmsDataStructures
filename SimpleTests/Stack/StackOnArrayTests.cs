using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures.Stack;
using System;

namespace DataStructures.Tests.Stack
{
    [TestClass]
    public class StackOnArrayTests
    {
        [TestMethod]
        public void Constructor_ShouldInitializeEmptyStack()
        {
            // Arrange
            int size = 5;

            // Act
            var stack = new StackOnArray<int>(size);

            // Assert
            Assert.IsTrue(stack.IsEmpty);
            Assert.AreEqual(0, stack.Count);
            Assert.AreEqual(size, stack.Capacity);
        }

        [TestMethod]
        public void Push_ShouldAddElementToStack()
        {
            // Arrange
            var stack = new StackOnArray<int>(5);
            int expectedData = 10;

            // Act
            stack.Push(expectedData);

            // Assert
            Assert.IsFalse(stack.IsEmpty);
            Assert.AreEqual(1, stack.Count);
            Assert.AreEqual(expectedData, stack.Peek());
        }

        [TestMethod]
        [ExpectedException(typeof(StackOverflowException))]
        public void Push_ShouldThrowExceptionWhenStackIsFull()
        {
            // Arrange
            var stack = new StackOnArray<int>(1);
            stack.Push(1);

            // Act
            stack.Push(2);
        }

        [TestMethod]
        public void Pop_ShouldRemoveAndReturnTopElement()
        {
            // Arrange
            var stack = new StackOnArray<int>(5);
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
            var stack = new StackOnArray<int>(5);

            // Act
            stack.Pop();
        }

        [TestMethod]
        public void Peek_ShouldReturnTopElementWithoutRemovingIt()
        {
            // Arrange
            var stack = new StackOnArray<int>(5);
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
            var stack = new StackOnArray<int>(5);

            // Act
            stack.Peek();
        }
    }
}
