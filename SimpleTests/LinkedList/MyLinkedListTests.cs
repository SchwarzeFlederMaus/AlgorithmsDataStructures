using DataStructures.LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace SimpleTests.LinkedList
{
    [TestClass]
    public sealed class MyLinkedListTests
    {
        [TestMethod]
        public void Constructor_EmptyList_ShouldBeEmpty()
        {
            var list = new MyLinkedList<int>();
            Assert.IsNull(list.Head);
            Assert.IsNull(list.Tail);
            Assert.AreEqual(0, list.Count);
        }

        [TestMethod]
        public void Constructor_WithSingleElement_ShouldContainElement()
        {
            var list = new MyLinkedList<int>(5);
            Assert.IsNotNull(list.Head);
            Assert.IsNotNull(list.Tail);
            Assert.AreEqual(1, list.Count);
            Assert.AreEqual(5, list.Head.Data);
            Assert.AreEqual(5, list.Tail.Data);
        }

        [TestMethod]
        public void AppendFirst_ShouldAddElementToStart()
        {
            var list = new MyLinkedList<int>();
            list.AppendFirst(10);
            Assert.AreEqual(1, list.Count);
            Assert.AreEqual(10, list.Head.Data);
            Assert.AreEqual(10, list.Tail.Data);

            list.AppendFirst(20);
            Assert.AreEqual(2, list.Count);
            Assert.AreEqual(20, list.Head.Data);
            Assert.AreEqual(10, list.Tail.Data);
        }

        [TestMethod]
        public void Add_ShouldAddElementToEnd()
        {
            var list = new MyLinkedList<int>();
            list.Add(10);
            Assert.AreEqual(1, list.Count);
            Assert.AreEqual(10, list.Head.Data);
            Assert.AreEqual(10, list.Tail.Data);

            list.Add(20);
            Assert.AreEqual(2, list.Count);
            Assert.AreEqual(10, list.Head.Data);
            Assert.AreEqual(20, list.Tail.Data);
        }

        [TestMethod]
        public void Remove_ShouldRemoveElement()
        {
            var list = new MyLinkedList<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);

            list.Remove(20);
            Assert.AreEqual(2, list.Count);
            Assert.IsFalse(list.Contains(20));
            Assert.IsTrue(list.Contains(10));
            Assert.IsTrue(list.Contains(30));

            list.Remove(10);
            Assert.AreEqual(1, list.Count);
            Assert.IsFalse(list.Contains(10));
            Assert.IsTrue(list.Contains(30));

            list.Remove(30);
            Assert.AreEqual(0, list.Count);
            Assert.IsFalse(list.Contains(30));
        }

        [TestMethod]
        public void Clear_ShouldRemoveAllElements()
        {
            var list = new MyLinkedList<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);

            list.Clear();
            Assert.AreEqual(0, list.Count);
            Assert.IsNull(list.Head);
            Assert.IsNull(list.Tail);
        }

        [TestMethod]
        public void Contains_ShouldReturnTrueIfElementExists()
        {
            var list = new MyLinkedList<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);

            Assert.IsTrue(list.Contains(10));
            Assert.IsTrue(list.Contains(20));
            Assert.IsTrue(list.Contains(30));
            Assert.IsFalse(list.Contains(40));
        }

        [TestMethod]
        public void GetEnumerator_ShouldEnumerateAllElements()
        {
            var list = new MyLinkedList<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);

            var elements = new List<int>();
            foreach (var item in list)
            {
                elements.Add(item);
            }

            CollectionAssert.AreEqual(new List<int> { 10, 20, 30 }, elements);
        }
    }
}
