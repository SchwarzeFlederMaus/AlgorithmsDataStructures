using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures.Dictionary;

namespace DataStructures.Tests.Dictionary
{
    [TestClass]
    public class NodeTests
    {
        [TestMethod]
        public void Node_Constructor_ShouldInitializeProperties()
        {
            // Arrange
            var key = "key";
            var value = "value";

            // Act
            var node = new Node<string, string>(key, value);

            // Assert
            Assert.AreEqual(key, node.Key);
            Assert.AreEqual(value, node.Value);
            Assert.IsNull(node.Next);
        }

        [TestMethod]
        public void Node_SetNext_ShouldUpdateNextProperty()
        {
            // Arrange
            var node1 = new Node<string, string>("key1", "value1");
            var node2 = new Node<string, string>("key2", "value2");

            // Act
            node1.Next = node2;

            // Assert
            Assert.AreEqual(node2, node1.Next);
        }
    }
}
