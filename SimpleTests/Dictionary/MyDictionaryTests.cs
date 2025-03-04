using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures.Dictionary;
using System;
using System.Collections.Generic;

namespace Dictionary
{
    [TestClass]
    public class MyDictionaryTests
    {
        [TestMethod]
        public void MyDictionary_Constructor_ShouldInitializeProperties()
        {
            // Act
            var dictionary = new MyDictionary<string, string>();

            // Assert
            Assert.AreEqual(0, dictionary.Count);
            Assert.IsTrue(dictionary.IsEmpty);
        }

        [TestMethod]
        public void MyDictionary_Add_ShouldAddKeyValuePair()
        {
            // Arrange
            var dictionary = new MyDictionary<string, string>();

            // Act
            dictionary.Add("key", "value");

            // Assert
            Assert.AreEqual(1, dictionary.Count);
            Assert.IsFalse(dictionary.IsEmpty);
            Assert.AreEqual("value", dictionary.GetValue("key"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void MyDictionary_Add_ShouldThrowException_WhenKeyIsNull()
        {
            // Arrange
            var dictionary = new MyDictionary<string, string>();

            // Act
            dictionary.Add(null, "value");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void MyDictionary_Add_ShouldThrowException_WhenKeyAlreadyExists()
        {
            // Arrange
            var dictionary = new MyDictionary<string, string>();
            dictionary.Add("key", "value");

            // Act
            dictionary.Add("key", "new value");
        }

        [TestMethod]
        public void MyDictionary_Remove_ShouldRemoveKeyValuePair()
        {
            // Arrange
            var dictionary = new MyDictionary<string, string>();
            dictionary.Add("key", "value");

            // Act
            dictionary.Remove("key");

            // Assert
            Assert.AreEqual(0, dictionary.Count);
            Assert.IsTrue(dictionary.IsEmpty);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void MyDictionary_Remove_ShouldThrowException_WhenKeyIsNull()
        {
            // Arrange
            var dictionary = new MyDictionary<string, string>();

            // Act
            dictionary.Remove(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void MyDictionary_Remove_ShouldThrowException_WhenKeyNotFound()
        {
            // Arrange
            var dictionary = new MyDictionary<string, string>();

            // Act
            dictionary.Remove("key");
        }

        [TestMethod]
        public void MyDictionary_GetValue_ShouldReturnValue()
        {
            // Arrange
            var dictionary = new MyDictionary<string, string>();
            dictionary.Add("key", "value");

            // Act
            var value = dictionary.GetValue("key");

            // Assert
            Assert.AreEqual("value", value);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void MyDictionary_GetValue_ShouldThrowException_WhenKeyIsNull()
        {
            // Arrange
            var dictionary = new MyDictionary<string, string>();

            // Act
            dictionary.GetValue(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void MyDictionary_GetValue_ShouldThrowException_WhenKeyNotFound()
        {
            // Arrange
            var dictionary = new MyDictionary<string, string>();

            // Act
            dictionary.GetValue("key");
        }

        [TestMethod]
        public void MyDictionary_Clear_ShouldRemoveAllItems()
        {
            // Arrange
            var dictionary = new MyDictionary<string, string>();
            dictionary.Add("key", "value");

            // Act
            dictionary.Clear();

            // Assert
            Assert.AreEqual(0, dictionary.Count);
            Assert.IsTrue(dictionary.IsEmpty);
        }

        [TestMethod]
        public void MyDictionary_ContainsKey_ShouldReturnTrue_WhenKeyExists()
        {
            // Arrange
            var dictionary = new MyDictionary<string, string>();
            dictionary.Add("key", "value");

            // Act
            var result = dictionary.ContainsKey("key");

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void MyDictionary_ContainsKey_ShouldReturnFalse_WhenKeyDoesNotExist()
        {
            // Arrange
            var dictionary = new MyDictionary<string, string>();

            // Act
            var result = dictionary.ContainsKey("key");

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void MyDictionary_ContainsValue_ShouldReturnTrue_WhenValueExists()
        {
            // Arrange
            var dictionary = new MyDictionary<string, string>();
            dictionary.Add("key", "value");

            // Act
            var result = dictionary.ContainsValue("value");

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void MyDictionary_ContainsValue_ShouldReturnFalse_WhenValueDoesNotExist()
        {
            // Arrange
            var dictionary = new MyDictionary<string, string>();

            // Act
            var result = dictionary.ContainsValue("value");

            // Assert
            Assert.IsFalse(result);
        }
    }
}
