using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures.Set;
using System.Collections.Generic;

namespace Set
{
    [TestClass]
    public class MySetTests
    {
        [TestMethod]
        public void Add_AddsItemToSet()
        {
            var set = new MySet<int>();
            set.Add(1);
            Assert.AreEqual(1, set.Count);
        }

        [TestMethod]
        public void Remove_RemovesItemFromSet()
        {
            var set = new MySet<int>();
            set.Add(1);
            set.Remove(1);
            Assert.AreEqual(0, set.Count);
        }

        [TestMethod]
        public void Clear_ClearsAllItems()
        {
            var set = new MySet<int>();
            set.Add(1);
            set.Add(2);
            set.Clear();
            Assert.AreEqual(0, set.Count);
        }

        [TestMethod]
        public void UnionWith_UnitesTwoSets()
        {
            var set1 = new MySet<int> { 1, 2 };
            var set2 = new MySet<int> { 2, 3 };
            var result = set1.UnionWith(set2);
            CollectionAssert.AreEquivalent(new List<int> { 1, 2, 3 }, new List<int>(result));
        }

        [TestMethod]
        public void IntersectWith_IntersectsTwoSets()
        {
            var set1 = new MySet<int> { 1, 2 };
            var set2 = new MySet<int> { 2, 3 };
            var result = set1.IntersectWith(set2);
            CollectionAssert.AreEquivalent(new List<int> { 2 }, new List<int>(result));
        }

        [TestMethod]
        public void DifferenceWith_DifferencesTwoSets()
        {
            var set1 = new MySet<int> { 1, 2 };
            var set2 = new MySet<int> { 2, 3 };
            var result = set1.DifferenceWith(set2);
            CollectionAssert.AreEquivalent(new List<int> { 1 }, new List<int>(result));
        }

        [TestMethod]
        public void IsSubset_ChecksIfSubset()
        {
            var set1 = new MySet<int> { 1, 2 };
            var set2 = new MySet<int> { 1, 2, 3 };
            Assert.IsTrue(set1.IsSubset(set2));
            Assert.IsFalse(set2.IsSubset(set1));
        }

        [TestMethod]
        public void SymmetricDifferenceWith_SymmetricDifferencesTwoSets()
        {
            var set1 = new MySet<int> { 1, 2 };
            var set2 = new MySet<int> { 2, 3 };
            var result = set1.SymmetricDifferenceWith(set2);
            CollectionAssert.AreEquivalent(new List<int> { 1, 3 }, new List<int>(result));
        }

        [TestMethod]
        public void IsEmpty_ChecksIfEmpty()
        {
            var set = new MySet<int>();
            Assert.IsTrue(set.IsEmpty);
            set.Add(1);
            Assert.IsFalse(set.IsEmpty);
        }
    }
}
