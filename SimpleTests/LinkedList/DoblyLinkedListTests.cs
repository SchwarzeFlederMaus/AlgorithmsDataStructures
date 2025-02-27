using DataStructures.LinkedList;

namespace DataStructures.Tests.LinkedList
{
    [TestClass]
    public class DoblyLinkedListTests
    {
        [TestMethod]
        public void Constructor_ShouldInitializeEmptyList()
        {
            // Act
            var list = new DoblyLinkedList<int>();

            // Assert
            Assert.IsTrue(list.IsEmpty);
        }

        [TestMethod]
        public void Add_ShouldAddElementToEnd()
        {
            // Arrange
            var list = new DoblyLinkedList<int>();

            // Act
            list.Add(1);

            // Assert
            Assert.AreEqual(1, list.Count);

            var enumerator = list.GetEnumerator();
            enumerator.MoveNext(); // Move to the first element
            Assert.AreEqual(1, enumerator.Current);
        }

        [TestMethod]
        public void AddFirst_ShouldAddElementToStart()
        {
            // Arrange
            var list = new DoblyLinkedList<int>();

            // Act
            list.AddFirst(1);

            // Assert
            Assert.AreEqual(1, list.Count);

            var enumerator = list.GetEnumerator();
            enumerator.MoveNext(); // Move to the first element
            Assert.AreEqual(1, enumerator.Current);
        }

        [TestMethod]
        public void AddLast_ShouldAddElementToEnd()
        {
            // Arrange
            var list = new DoblyLinkedList<int>();

            // Act
            list.AddLast(1);

            // Assert
            Assert.AreEqual(1, list.Count);

            var enumerator = list.GetEnumerator();
            enumerator.MoveNext(); // Move to the first element
            Assert.AreEqual(1, enumerator.Current);
        }

        [TestMethod]
        public void Delete_ShouldRemoveElement()
        {
            // Arrange
            var list = new DoblyLinkedList<int>();
            list.Add(1);
            list.Add(2);

            // Act
            list.Remove(1);

            // Assert
            Assert.AreEqual(1, list.Count);
        }

        [TestMethod]
        public void DeleteFirst_ShouldRemoveFirstElement()
        {
            // Arrange
            var list = new DoblyLinkedList<int>();
            list.Add(1);
            list.Add(2);

            // Act
            list.DeleteFirst();

            // Assert
            Assert.AreEqual(1, list.Count);

            var enumerator = list.GetEnumerator();
            enumerator.MoveNext(); // Move to the first element
            Assert.AreEqual(2, enumerator.Current);
        }

        [TestMethod]
        public void DeleteLast_ShouldRemoveLastElement()
        {
            // Arrange
            var list = new DoblyLinkedList<int>();
            list.Add(1);
            list.Add(2);

            // Act
            list.DeleteLast();

            // Assert
            Assert.AreEqual(1, list.Count);
        }

        [TestMethod]
        public void Reverse_ShouldReturnReversedList()
        {
            // Arrange
            var list = new DoblyLinkedList<int>();
            list.Add(1);
            list.Add(2);

            // Act
            var reversed = list.Reverse();

            // Assert
            var enumerator = reversed.GetEnumerator();
            enumerator.MoveNext(); // Move to the first element
            Assert.AreEqual(2, enumerator.Current);
            enumerator.MoveNext(); // Move to the next element
            Assert.AreEqual(1, enumerator.Current);
        }

        [TestMethod]
        public void Clear_ShouldEmptyTheList()
        {
            // Arrange
            var list = new DoblyLinkedList<int>();
            list.Add(1);
            list.Add(2);

            // Act
            list.Clear();

            // Assert
            Assert.IsTrue(list.IsEmpty);
        }
    }
}
