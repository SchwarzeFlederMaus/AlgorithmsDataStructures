using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures.BinarySearchTree;
using System.Collections.Generic;

namespace BinarySearchTree
{
    [TestClass]
    public class MyBinarySearchTreeTests
    {
        [TestMethod]
        public void MyBinarySearchTree_Add()
        {
            var tree = new MyBinarySearchTree<int>();
            tree.Add(5);
            tree.Add(3);
            tree.Add(7);

            Assert.AreEqual(3, tree.Count);
            Assert.IsTrue(tree.Contains(5));
            Assert.IsTrue(tree.Contains(3));
            Assert.IsTrue(tree.Contains(7));
        }

        [TestMethod]
        public void MyBinarySearchTree_Remove()
        {
            var tree = new MyBinarySearchTree<int>();
            tree.Add(5);
            tree.Add(3);
            tree.Add(7);
            tree.Remove(3);

            Assert.AreEqual(2, tree.Count);
            Assert.IsFalse(tree.Contains(3));
        }

        [TestMethod]
        public void MyBinarySearchTree_Contains()
        {
            var tree = new MyBinarySearchTree<int>();
            tree.Add(5);
            tree.Add(3);
            tree.Add(7);

            Assert.IsTrue(tree.Contains(5));
            Assert.IsTrue(tree.Contains(3));
            Assert.IsTrue(tree.Contains(7));
            Assert.IsFalse(tree.Contains(10));
        }

        [TestMethod]
        public void MyBinarySearchTree_InOrderTraversal()
        {
            var tree = new MyBinarySearchTree<int>();
            tree.Add(5);
            tree.Add(3);
            tree.Add(7);
            tree.Add(1);
            tree.Add(4);

            var result = tree.InOrderTraversal();
            var expected = new List<int> { 1, 3, 4, 5, 7 };

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MyBinarySearchTree_PreOrderTraversal()
        {
            var tree = new MyBinarySearchTree<int>();
            tree.Add(5);
            tree.Add(3);
            tree.Add(7);
            tree.Add(1);
            tree.Add(4);

            var result = tree.PreOrderTraversal();
            var expected = new List<int> { 5, 3, 1, 4, 7 };

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MyBinarySearchTree_PostOrderTraversal()
        {
            var tree = new MyBinarySearchTree<int>();
            tree.Add(5);
            tree.Add(3);
            tree.Add(7);
            tree.Add(1);
            tree.Add(4);

            var result = tree.PostOrderTraversal();
            var expected = new List<int> { 1, 4, 3, 7, 5 };

            CollectionAssert.AreEqual(expected, result);
        }
    }
}
