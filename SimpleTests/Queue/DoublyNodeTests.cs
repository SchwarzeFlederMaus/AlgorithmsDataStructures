using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures.Queue;

namespace DataStructures.Tests.Queue
{
    [TestClass]
    public class DoublyNodeTests
    {
        [TestMethod]
        public void Constructor_ShouldInitializeData()
        {
            // Arrange
            var data = 5;

            // Act
            var node = new DoublyNode<int>(data);

            // Assert
            Assert.AreEqual(data, node.Data);
        }

        [TestMethod]
        public void ToString_ShouldReturnDataString()
        {
            // Arrange
            var data = 5;
            var node = new DoublyNode<int>(data);

            // Act
            var result = node.ToString();

            // Assert
            Assert.AreEqual(data.ToString(), result);
        }

        [TestMethod]
        public void NextProperty_ShouldGetAndSetNextNode()
        {
            // Arrange
            var node1 = new DoublyNode<int>(1);
            var node2 = new DoublyNode<int>(2);

            // Act
            node1.Next = node2;

            // Assert
            Assert.AreEqual(node2, node1.Next);
        }

        [TestMethod]
        public void PreviousProperty_ShouldGetAndSetPreviousNode()
        {
            // Arrange
            var node1 = new DoublyNode<int>(1);
            var node2 = new DoublyNode<int>(2);

            // Act
            node1.Previous = node2;

            // Assert
            Assert.AreEqual(node2, node1.Previous);
        }
    }
}
