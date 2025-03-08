using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures.BinaryHeap;

namespace BinaryHeap
{
    [TestClass]
    public class MyBinaryHeapTests
    {
        [TestMethod]
        public void Insert_ShouldAddElementToHeap()
        {
            var heap = new MyBinaryHeap<int>();
            heap.Insert(10);
            heap.Insert(20);
            heap.Insert(5);

            Assert.AreEqual(20, heap.DeleteRoot());
            Assert.AreEqual(10, heap.DeleteRoot());
            Assert.AreEqual(5, heap.DeleteRoot());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void DeleteRoot_ShouldThrowException_WhenHeapIsEmpty()
        {
            var heap = new MyBinaryHeap<int>();
            heap.DeleteRoot();
        }

        [TestMethod]
        public void DeleteRoot_ShouldRemoveRootElementFromHeap()
        {
            var heap = new MyBinaryHeap<int>();
            heap.Insert(10);
            heap.Insert(20);
            heap.Insert(5);

            Assert.AreEqual(20, heap.DeleteRoot());
            Assert.AreEqual(10, heap.DeleteRoot());
            Assert.AreEqual(5, heap.DeleteRoot());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Insert_ShouldThrowException_WhenHeapIsFull()
        {
            var heap = new MyBinaryHeap<int>(2);
            heap.Insert(10);
            heap.Insert(20);
            heap.Insert(30);
        }
    }

    [TestClass]
    public class NodeTests
    {
        [TestMethod]
        public void CompareTo_ShouldReturnZero_WhenNodesAreEqual()
        {
            var node1 = new Node<int>(10);
            var node2 = new Node<int>(10);

            Assert.AreEqual(0, node1.CompareTo(node2.Data));
        }

        [TestMethod]
        public void CompareTo_ShouldReturnPositive_WhenNodeIsGreater()
        {
            var node1 = new Node<int>(20);
            var node2 = new Node<int>(10);

            Assert.IsTrue(node1.CompareTo(node2.Data) > 0);
        }

        [TestMethod]
        public void CompareTo_ShouldReturnNegative_WhenNodeIsSmaller()
        {
            var node1 = new Node<int>(5);
            var node2 = new Node<int>(10);

            Assert.IsTrue(node1.CompareTo(node2.Data) < 0);
        }
    }
}
