using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures.Set;
using System.Collections.Generic;

namespace Set
{
    [TestClass]
    public class SetOnListTests
    {
        [TestMethod]
        public void TestConstructor_Empty()
        {
            var set = new SetOnList<int>();
            Assert.AreEqual(0, set.Count);
            Assert.IsTrue(set.IsEmpty);
        }

        [TestMethod]
        public void TestConstructor_SingleItem()
        {
            var set = new SetOnList<int>(5);
            Assert.AreEqual(1, set.Count);
            Assert.IsFalse(set.IsEmpty);
        }

        [TestMethod]
        public void TestConstructor_Collection()
        {
            var set = new SetOnList<int>(new[] { 1, 2, 3 });
            Assert.AreEqual(3, set.Count);
            Assert.IsFalse(set.IsEmpty);
        }

        [TestMethod]
        public void TestAdd()
        {
            var set = new SetOnList<int>();
            set.Add(1);
            Assert.AreEqual(1, set.Count);
            set.Add(1); // Adding duplicate
            Assert.AreEqual(1, set.Count);
        }

        [TestMethod]
        public void TestRemove()
        {
            var set = new SetOnList<int>(new[] { 1, 2, 3 });
            set.Remove(2);
            Assert.AreEqual(2, set.Count);
            set.Remove(4); // Removing non-existent item
            Assert.AreEqual(2, set.Count);
        }

        [TestMethod]
        public void TestClear()
        {
            var set = new SetOnList<int>(new[] { 1, 2, 3 });
            set.Clear();
            Assert.AreEqual(0, set.Count);
            Assert.IsTrue(set.IsEmpty);
        }

        [TestMethod]
        public void TestUnionWith()
        {
            var setA = new SetOnList<int>(new[] { 1, 2, 3 });
            var setB = new SetOnList<int>(new[] { 3, 4, 5 });
            var result = setA.UnionWith(setB);
            CollectionAssert.AreEquivalent(new[] { 1, 2, 3, 4, 5 }, result);
        }

        [TestMethod]
        public void TestIntersectWith()
        {
            var setA = new SetOnList<int>(new[] { 1, 2, 3 });
            var setB = new SetOnList<int>(new[] { 3, 4, 5 });
            var result = setA.IntersectWith(setB);
            CollectionAssert.AreEquivalent(new[] { 3 }, result);
        }

        [TestMethod]
        public void TestDifferenceWith()
        {
            var setA = new SetOnList<int>(new[] { 1, 2, 3 });
            var setB = new SetOnList<int>(new[] { 3, 4, 5 });
            var result = setA.DifferenceWith(setB);
            CollectionAssert.AreEquivalent(new[] { 1, 2 }, result);
        }

        [TestMethod]
        public void TestIsSubset()
        {
            var setA = new SetOnList<int>(new[] { 1, 2, 3 });
            var setB = new SetOnList<int>(new[] { 1, 2, 3, 4, 5 });
            Assert.IsTrue(setA.IsSubset(setB));
            Assert.IsFalse(setB.IsSubset(setA));
        }

        [TestMethod]
        public void TestSymmetricDifferenceWith()
        {
            var setA = new SetOnList<int>(new[] { 1, 2, 3 });
            var setB = new SetOnList<int>(new[] { 3, 4, 5 });
            var result = setA.SymmetricDifferenceWith(setB);
            CollectionAssert.AreEquivalent(new[] { 1, 2, 4, 5 }, result);
        }
    }
}
