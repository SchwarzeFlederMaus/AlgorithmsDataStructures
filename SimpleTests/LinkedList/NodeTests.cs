using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures.LinkedList;

namespace DataStructures.Tests
{
    [TestClass]
    public class NodeTests
    {
        [TestMethod]
        public void Constructor_ShouldInitializeData()
        {
            // Arrange
            int expectedData = 5;

            // Act
            var node = new Node<int>(expectedData);

            // Assert
            Assert.AreEqual(expectedData, node.Data);
        }

        [TestMethod]
        public void DataProperty_ShouldGetAndSetData()
        {
            // Arrange
            var node = new Node<int>(0);
            int expectedData = 10;

            // Act
            node.Data = expectedData;

            // Assert
            Assert.AreEqual(expectedData, node.Data);
        }

        [TestMethod]
        public void NextProperty_ShouldGetAndSetNextNode()
        {
            // Arrange
            var node1 = new Node<int>(1);
            var node2 = new Node<int>(2);

            // Act
            node1.Next = node2;

            // Assert
            Assert.AreEqual(node2, node1.Next);
        }
    }
}
