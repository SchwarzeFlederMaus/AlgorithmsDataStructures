using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures.LinkedList;
using System.Collections.Generic;

namespace LinkedList
{
    [TestClass]
    public class CircularListTests
    {
        [TestMethod]
        public void Constructor_ShouldInitializeEmptyList()
        {
            // Arrange & Act
            var list = new CircularList<int>();

            // Assert
            Assert.AreEqual(0, list.Count);
            Assert.IsTrue(list.IsEmpty);
        }

        [TestMethod]
        public void Constructor_WithData_ShouldInitializeListWithOneElement()
        {
            // Arrange & Act
            var list = new CircularList<int>(5);

            // Assert
            Assert.AreEqual(1, list.Count);
            Assert.IsFalse(list.IsEmpty);
        }

        [TestMethod]
        public void Constructor_WithCollection_ShouldInitializeListWithElements()
        {
            // Arrange
            var collection = new List<int> { 1, 2, 3 };

            // Act
            var list = new CircularList<int>(collection);

            // Assert
            Assert.AreEqual(3, list.Count);
            CollectionAssert.AreEqual(collection, new List<int>(list));
        }

        [TestMethod]
        public void Add_ShouldIncreaseCount()
        {
            // Arrange
            var list = new CircularList<int>();

            // Act
            list.Add(1);

            // Assert
            Assert.AreEqual(1, list.Count);
        }

        [TestMethod]
        public void Add_ShouldAddElementToList()
        {
            // Arrange
            var list = new CircularList<int>();

            // Act
            list.Add(1);
            list.Add(2);

            // Assert
            CollectionAssert.AreEqual(new List<int> { 1, 2 }, new List<int>(list));
        }

        [TestMethod]
        public void Remove_ShouldDecreaseCount()
        {
            // Arrange
            var list = new CircularList<int>();
            list.Add(1);
            list.Add(2);

            // Act
            list.Remove(1);

            // Assert
            Assert.AreEqual(1, list.Count);
        }

        [TestMethod]
        public void Remove_ShouldRemoveElementFromList()
        {
            // Arrange
            var list = new CircularList<int>();
            list.Add(1);
            list.Add(2);

            // Act
            list.Remove(1);

            // Assert
            CollectionAssert.AreEqual(new List<int> { 2 }, new List<int>(list));
        }

        [TestMethod]
        public void Remove_ShouldNotChangeCount_WhenItemNotFound()
        {
            // Arrange
            var list = new CircularList<int>();
            list.Add(1);
            list.Add(2);

            // Act
            list.Remove(3);

            // Assert
            Assert.AreEqual(2, list.Count);
        }

        [TestMethod]
        public void Clear_ShouldResetCount()
        {
            // Arrange
            var list = new CircularList<int>();
            list.Add(1);
            list.Add(2);

            // Act
            list.Clear();

            // Assert
            Assert.AreEqual(0, list.Count);
            Assert.IsTrue(list.IsEmpty);
        }

        [TestMethod]
        public void Enumerator_ShouldIterateOverAllItems()
        {
            // Arrange
            var list = new CircularList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            // Act
            var items = new List<int>();
            foreach (var item in list)
            {
                items.Add(item);
            }

            // Assert
            CollectionAssert.AreEqual(new List<int> { 1, 2, 3 }, items);
        }
    }
}
