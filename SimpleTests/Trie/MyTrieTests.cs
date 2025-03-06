using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures.Trie;

namespace Trie
{
    [TestClass]
    public class MyTrieTests
    {
        private MyTrie<int> trie;

        [TestInitialize]
        public void Setup()
        {
            trie = new MyTrie<int>();
        }

        [TestMethod]
        public void AddAndSearchTest()
        {
            trie.Add("apple", 1);
            Assert.IsTrue(trie.Search("apple"));
            Assert.IsFalse(trie.Search("app"));
        }

        [TestMethod]
        public void DeleteTest()
        {
            trie.Add("apple", 1);
            trie.Delete("apple");
            Assert.IsFalse(trie.Search("apple"));
        }

        [TestMethod]
        public void GetDataTest()
        {
            trie.Add("apple", 1);
            Assert.AreEqual(1, trie.GetData("apple"));
            Assert.AreEqual(default(int), trie.GetData("app"));
        }
    }
}
