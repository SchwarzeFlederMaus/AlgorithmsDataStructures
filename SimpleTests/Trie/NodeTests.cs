using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures.Trie;

namespace Trie
{
    [TestClass]
    public class NodeTests
    {
        [TestMethod]
        public void NodeInitializationTest()
        {
            var node = new Node<int>(5);
            Assert.AreEqual(5, node.Data);
            Assert.IsNotNull(node.Children);
            Assert.AreEqual(26, node.Children.Length);
            Assert.IsFalse(node.IsEndOfWord);
        }

        [TestMethod]
        public void NodeParentTest()
        {
            var parentNode = new Node<int>(10);
            var childNode = new Node<int>(5) { Parent = parentNode };
            Assert.AreEqual(parentNode, childNode.Parent);
        }
    }
}
