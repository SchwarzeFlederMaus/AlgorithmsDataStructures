using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures.BinarySearchTree;

namespace BinarySearchTree
{
    [TestClass]
    public class NodeTests
    {
        [TestMethod]
        public void Node_Constructor_SetsData()
        {
            var node = new Node<int>(5);
            Assert.AreEqual(5, node.Data);
            Assert.IsNull(node.Left);
            Assert.IsNull(node.Right);
        }

        [TestMethod]
        public void Node_Constructor_SetsDataAndChildren()
        {
            var leftNode = new Node<int>(3);
            var rightNode = new Node<int>(7);
            var node = new Node<int>(5, leftNode, rightNode);

            Assert.AreEqual(5, node.Data);
            Assert.AreEqual(leftNode, node.Left);
            Assert.AreEqual(rightNode, node.Right);
        }

        [TestMethod]
        public void Node_CompareTo_Node()
        {
            var node1 = new Node<int>(5);
            var node2 = new Node<int>(3);
            var node3 = new Node<int>(5);

            Assert.IsTrue(node1.CompareTo(node2) > 0);
            Assert.IsTrue(node2.CompareTo(node1) < 0);
            Assert.IsTrue(node1.CompareTo(node3) == 0);
        }

        [TestMethod]
        public void Node_CompareTo_Data()
        {
            var node = new Node<int>(5);

            Assert.IsTrue(node.CompareTo(3) > 0);
            Assert.IsTrue(node.CompareTo(7) < 0);
            Assert.IsTrue(node.CompareTo(5) == 0);
        }
    }
}
