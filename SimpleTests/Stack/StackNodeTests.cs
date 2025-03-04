using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures.Stack;

namespace Stack
{
    [TestClass]
    public class StackNodeTests
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
        public void PreviousProperty_ShouldGetAndSetPreviousNode()
        {
            // Arrange
            var node1 = new Node<int>(1);
            var node2 = new Node<int>(2);

            // Act
            node1.Previous = node2;

            // Assert
            Assert.AreEqual(node2, node1.Previous);
        }
    }
}
