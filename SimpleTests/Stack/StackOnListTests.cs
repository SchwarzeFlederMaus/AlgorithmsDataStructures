using DataStructures.Stack;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Stack
{
    [TestClass]
    public sealed class StackOnListTests
    {
        [TestMethod]
        public void Constructor_EmptyStack_ShouldBeEmpty()
        {
            var stack = new StackOnList<int>();
            Assert.IsTrue(stack.IsEmpty);
            Assert.AreEqual(0, stack.Count);
        }

        [TestMethod]
        public void Constructor_WithSingleElement_ShouldContainElement()
        {
            var stack = new StackOnList<int>(5);
            Assert.IsFalse(stack.IsEmpty);
            Assert.AreEqual(1, stack.Count);
            Assert.AreEqual(5, stack.Peek());
        }

        [TestMethod]
        public void Constructor_WithCollection_ShouldContainElements()
        {
            var collection = new List<int> { 1, 2, 3 };
            var stack = new StackOnList<int>(collection);
            Assert.IsFalse(stack.IsEmpty);
            Assert.AreEqual(3, stack.Count);
            Assert.AreEqual(3, stack.Peek());
        }

        [TestMethod]
        public void Push_ShouldAddElementToStack()
        {
            var stack = new StackOnList<int>();
            stack.Push(10);
            Assert.IsFalse(stack.IsEmpty);
            Assert.AreEqual(1, stack.Count);
            Assert.AreEqual(10, stack.Peek());
        }

        [TestMethod]
        public void Pop_ShouldRemoveAndReturnTopElement()
        {
            var stack = new StackOnList<int>(new List<int> { 1, 2, 3 });
            var topElement = stack.Pop();
            Assert.AreEqual(3, topElement);
            Assert.AreEqual(2, stack.Count);
            Assert.AreEqual(2, stack.Peek());
        }

        [TestMethod]
        [ExpectedException(typeof(StackOverflowException))]
        public void Pop_EmptyStack_ShouldThrowException()
        {
            var stack = new StackOnList<int>();
            stack.Pop();
        }

        [TestMethod]
        public void Peek_ShouldReturnTopElementWithoutRemoving()
        {
            var stack = new StackOnList<int>(new List<int> { 1, 2, 3 });
            var topElement = stack.Peek();
            Assert.AreEqual(3, topElement);
            Assert.AreEqual(3, stack.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(StackOverflowException))]
        public void Peek_EmptyStack_ShouldThrowException()
        {
            var stack = new StackOnList<int>();
            stack.Peek();
        }

        [TestMethod]
        public void Clear_ShouldRemoveAllElements()
        {
            var stack = new StackOnList<int>(new List<int> { 1, 2, 3 });
            stack.Clear();
            Assert.IsTrue(stack.IsEmpty);
            Assert.AreEqual(0, stack.Count);
        }
    }
}
