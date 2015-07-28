using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomLinkedListTests
{
    using CustomLinkedList;

    [TestClass]
    public class CustomLinkedListTests
    {
        [TestMethod]
        public void TestDynamicListConstructor_ShouldCreateANewInstanceOfDynamicListOfTheSameParameterType()
        {
            //Arange

            //Act
            var testDynamicList = new DynamicList<int>();

            //Assert
            Assert.IsInstanceOfType(testDynamicList, typeof(DynamicList<int>), "Dynamic List Constructor did not return an object of the correct type.");
        }

        [TestMethod]
        public void TestDynamicListCountPropertyOfAnEmptyObject_ShouldReturnTheAmountOfElementsInTheList()
        {
            //Arange
            var dynamicList = new DynamicList<int>();
            int expectedResult = 0;

            //Act

            //Assert
            Assert.AreEqual(dynamicList.Count, expectedResult, "List.Count returned an incorrect value!");
        }

        [TestMethod]
        public void TestDynamicListCountPropertyOfANonEmptyObject_ShouldReturnTheAmountOfElementsInTheList()
        {
            //Arange
            var dynamicList = new DynamicList<int>();
            int expectedResult = 3;

            //Act
            dynamicList.Add(5);
            dynamicList.Add(10);
            dynamicList.Add(15);

            //Assert
            Assert.AreEqual(dynamicList.Count, expectedResult, "List.Count returned an incorrect value!");
        }

        [TestMethod]
        public void TestDynamicListIndexatorGetter_ShouldReturnCorrectElementOfTheList()
        {
            //Arange
            var dynamicList = new DynamicList<int>();
            dynamicList.Add(5);
            dynamicList.Add(10);

            //Act
            var expectedResult = dynamicList[1];

            //Assert
            Assert.AreEqual(expectedResult, dynamicList[1], "Indexer getter returned an incorect value.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestDynamicListIndexatorGetter_ShouldThrowExceptionWhenWrongIndexIsInputed()
        {
            //Arange
            var dynamicList = new DynamicList<int>();
            dynamicList.Add(5);
            dynamicList.Add(10);

            //Act
            var testIndexer = dynamicList[10];
            var testIndexer2 = dynamicList[-5];

            //Assert
        }

        [TestMethod]
        public void TestDynamicListIndexatorSetter_ShouldOperateOverCorrectElementOfTheListAndSaveTheChanges()
        {
            //Arange
            var dynamicList = new DynamicList<int>();
            dynamicList.Add(5);
            int expectedResult = 333;

            //Act
            dynamicList[0] = 333;

            //Assert
            Assert.AreEqual(expectedResult, dynamicList[0], "Indexer setter did not change element values correctly.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestDynamicListIndexatorSetter_ShouldThrowExceptionWhenWrongIndexIsInputed()
        {
            //Arange
            var dynamicList = new DynamicList<int>();

            //Act
            dynamicList[10] = 50;
            dynamicList[-1] = 20;

            //Assert
        }



        [TestMethod]
        public void TestDynamicListAddMethod_ShouldAddAnElementToTheList()
        {
            //Arange
            var dynamicList = new DynamicList<int>();
            var expectedCount = 1;

            //Act
            dynamicList.Add(5);

            //Assert
            Assert.AreEqual(dynamicList.Count, expectedCount, "Add Method did not change List.Count correctly!");
        }

        [TestMethod]
        public void TestDynamicListAddMethod_ShouldAddAnElementToTheListWithTheSameValue()
        {
            //Arange
            var dynamicList = new DynamicList<int>();
            var expectedValue = 5;

            //Act
            dynamicList.Add(5);

            //Assert
            Assert.AreEqual(dynamicList[0], expectedValue, "Add Method did not add the element with a correct value!");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestDynamicListRemoveAtMethod_ShouldThrowExceptionWhenWrongIndexIsInputed()
        {
            //Arange
            var dynamicList = new DynamicList<int>();

            //Act
            dynamicList.RemoveAt(1);

            //Assert
        }

        [TestMethod]
        public void TestDynamicListRemoveAtMethod_ShouldRemoveTheElementAtTheGivenIndex()
        {
            //Arange
            var dynamicList = new DynamicList<int>();
            dynamicList.Add(5);
            dynamicList.Add(10);
            int expectedCount = 1;

            //Act
            dynamicList.RemoveAt(1);

            //Assert
            Assert.AreEqual(dynamicList.Count, expectedCount, "RemoveAt method didn't change List.Count correctly!");
        }

        [TestMethod]
        public void TestDynamicListRemoveAtMethod_ShouldReturnTheRemovedElementValue()
        {
            //Arange
            var dynamicList = new DynamicList<int>();
            dynamicList.Add(5);
            dynamicList.Add(10);
            var expectedValue = 5;

            //Act
            var removedElement = dynamicList.RemoveAt(0);

            //Assert
            Assert.AreEqual(removedElement, expectedValue, "RemoveAt method didn't return correct value!");
        }

        [TestMethod]
        public void TestDynamicListRemoveMethod_ShouldReturnANotFoundIndexIfElementIsNotFound()
        {
            //Arange
            var dynamicList = new DynamicList<int>();
            int expectedResult = -1;

            //Act
            var returnedElement = dynamicList.Remove(5);

            //Assert
            Assert.AreEqual(expectedResult, returnedElement, @"Remove method did not return ""-1"" when the element doesn't exist!");
        }

        [TestMethod]
        public void TestDynamicListRemoveMethod_ShouldRemoveTheGivenElementFromTheList()
        {
            //Arange
            var dynamicList = new DynamicList<int>();
            dynamicList.Add(5);
            dynamicList.Add(10);
            int expectedCount = 1;

            //Act
            dynamicList.Remove(5);

            //Assert
            Assert.AreEqual(dynamicList.Count, expectedCount, "Remove method didn't change List.Count correctly!");
        }

        [TestMethod]
        public void TestDynamicListRemoveMethod_ShouldReturnTheRemovedElementIndex()
        {
            //Arange
            var dynamicList = new DynamicList<int>();
            dynamicList.Add(5);
            dynamicList.Add(10);
            int expectedIndex = 1;

            //Act
            var removedElement = dynamicList.Remove(10);

            //Assert
            Assert.AreEqual(removedElement, expectedIndex, "Remove method didn't return correct index!");
        }

        [TestMethod]
        public void TestDynamicListIndexOfMethod_ShouldReturnANotFoundIndexIfElementIsNotFound()
        {
            //Arange
            var dynamicList = new DynamicList<int>();
            int expectedIndex = -1;

            //Act
            var returnedIndex = dynamicList.IndexOf(5);

            //Assert
            Assert.AreEqual(expectedIndex, returnedIndex, @"IndexOf method did not return ""-1"" when the element doesn't exist!");
        }

        [TestMethod]
        public void TestDynamicListIndexOfMethod_ShouldReturnTheIndexOfSpecifiedElement()
        {
            //Arange
            var dynamicList = new DynamicList<int>();
            dynamicList.Add(5);
            dynamicList.Add(10);
            int expectedIndex = 1;

            //Act
            var returnedIndex = dynamicList.IndexOf(10);

            //Assert
            Assert.AreEqual(returnedIndex, expectedIndex, "IndexOf method didn't return correct index!");
        }

        [TestMethod]
        public void TestDynamicListContainsMethod_ShouldReturnFalseIfTheElementDoesNotExistInTheList()
        {
            //Arange
            var dynamicList = new DynamicList<int>();
            bool expectedResult = false;

            //Act
            var returnedResult = dynamicList.Contains(10);

            //Assert
            Assert.AreEqual(returnedResult, expectedResult, "Contains method didn't return correct result!");
        }

        [TestMethod]
        public void TestDynamicListContainsMethod_ShouldReturnTrueIfTheElementExistsInTheList()
        {
            //Arange
            var dynamicList = new DynamicList<int>();
            dynamicList.Add(5);
            dynamicList.Add(10);
            bool expectedResult = true;

            //Act
            var returnedResult = dynamicList.Contains(10);

            //Assert
            Assert.AreEqual(returnedResult, expectedResult, "Contains method didn't return correct result!");
        }
    }
}
