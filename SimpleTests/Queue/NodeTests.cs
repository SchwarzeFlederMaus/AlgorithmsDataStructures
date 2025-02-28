using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures.Queue;

namespace DataStructures.Tests.Queue
{
    [TestClass]
    public class NodeTests
    {
        [TestMethod]
        public void Node_Constructor_ShouldInitializeData()
        {
            // Arrange
            var data = 5;

            // Act
            var node = new Node<int>(data);

            // Assert
            Assert.AreEqual(data, node.Data);
        }

        [TestMethod]
        public void Node_ToString_ShouldReturnDataToString()
        {
            // Arrange
            var data = 5;
            var node = new Node<int>(data);

            // Act
            var result = node.ToString();

            // Assert
            Assert.AreEqual(data.ToString(), result);
        }

        [TestMethod]
        public void Node_Next_ShouldBeNullByDefault()
        {
            // Arrange
            var node = new Node<int>(5);

            // Act
            var nextNode = node.Next;

            // Assert
            Assert.IsNull(nextNode);
        }

        [TestMethod]
        public void Node_SetNext_ShouldUpdateNextNode()
        {
            // Arrange
            var node1 = new Node<int>(5);
            var node2 = new Node<int>(10);

            // Act
            node1.Next = node2;

            // Assert
            Assert.AreEqual(node2, node1.Next);
        }
    }
}
