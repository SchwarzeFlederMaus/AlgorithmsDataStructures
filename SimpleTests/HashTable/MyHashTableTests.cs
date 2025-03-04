using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures.HashTable;
using System.Collections.Generic;

namespace HashTable
{
    [TestClass]
    public class MyHashTableTests
    {
        [TestMethod]
        public void Add_AddsKeyValuePair()
        {
            var hashTable = new MyHashTable<int, string>(10);
            hashTable.Add(1, "value1");

            Assert.AreEqual(1, hashTable.Count);
            Assert.IsTrue(hashTable.Contains(1, "value1"));
        }

        [TestMethod]
        public void Remove_RemovesKey()
        {
            var hashTable = new MyHashTable<int, string>(10);
            hashTable.Add(1, "value1");
            hashTable.Remove(1);

            Assert.AreEqual(0, hashTable.Count);
            Assert.IsFalse(hashTable.ContainsKey(1));
        }

        [TestMethod]
        public void Remove_RemovesKeyValuePair()
        {
            var hashTable = new MyHashTable<int, string>(10);
            hashTable.Add(1, "value1");
            hashTable.Remove(1, "value1");

            Assert.AreEqual(0, hashTable.Count);
            Assert.IsFalse(hashTable.Contains(1, "value1"));
        }

        [TestMethod]
        public void Get_ReturnsValuesForKey()
        {
            var hashTable = new MyHashTable<int, string>(10);
            hashTable.Add(1, "value1");
            hashTable.Add(1, "value2");

            var values = hashTable.Get(1);

            Assert.AreEqual(2, values.Count);
            Assert.IsTrue(values.Contains("value1"));
            Assert.IsTrue(values.Contains("value2"));
        }

        [TestMethod]
        public void Get_ReturnsValueAtIndex()
        {
            var hashTable = new MyHashTable<int, string>(10);
            hashTable.Add(1, "value1");
            hashTable.Add(1, "value2");

            var value = hashTable.Get(1, 1);

            Assert.AreEqual("value2", value);
        }

        [TestMethod]
        public void Contains_ReturnsTrueIfKeyValuePairExists()
        {
            var hashTable = new MyHashTable<int, string>(10);
            hashTable.Add(1, "value1");

            Assert.IsTrue(hashTable.Contains(1, "value1"));
        }

        [TestMethod]
        public void ContainsKey_ReturnsTrueIfKeyExists()
        {
            var hashTable = new MyHashTable<int, string>(10);
            hashTable.Add(1, "value1");

            Assert.IsTrue(hashTable.ContainsKey(1));
        }

        [TestMethod]
        public void ContainsValue_ReturnsTrueIfValueExists()
        {
            var hashTable = new MyHashTable<int, string>(10);
            hashTable.Add(1, "value1");

            Assert.IsTrue(hashTable.ContainsValue("value1"));
        }

        [TestMethod]
        public void Clear_RemovesAllItems()
        {
            var hashTable = new MyHashTable<int, string>(10);
            hashTable.Add(1, "value1");
            hashTable.Clear();

            Assert.AreEqual(0, hashTable.Count);
            Assert.IsTrue(hashTable.IsEmpty);
        }

        [TestMethod]
        public void IsEmpty_ReturnsTrueIfEmpty()
        {
            var hashTable = new MyHashTable<int, string>(10);

            Assert.IsTrue(hashTable.IsEmpty);
        }

        [TestMethod]
        public void Capacity_ReturnsSize()
        {
            var hashTable = new MyHashTable<int, string>(10);

            Assert.AreEqual(10, hashTable.Capacity);
        }
    }
}
