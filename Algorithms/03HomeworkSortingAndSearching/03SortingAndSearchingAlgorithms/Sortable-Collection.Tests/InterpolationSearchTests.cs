namespace Sortable_Collection.Tests
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class InterpolationSearchTests
    {
        private static readonly Random Random = new Random();

        [TestMethod]
        public void InterpolationWithEmptyCollectionShouldReturnMissingElement()
        {
            var collection = new SortableCollection<int>();

            var result = collection.InterpolationSearch(0);
            var expected = Array.BinarySearch(collection.ToArray(), 0);

            Assert.AreEqual(expected, result, "No elements are present in an empty collection; method should return -1.");
        }

        [TestMethod]
        public void InterpolationWithMissingElement()
        {
            var collection = new SortableCollection<int>(-1, 1, 5, 12, 50);

            var result = collection.InterpolationSearch(0);
            var expected = -1;

            Assert.AreEqual(expected, result, "Missing element should return -1.");
        }

        [TestMethod]
        public void InterpolationWithItemAtMidpoint()
        {
            var collection = new SortableCollection<int>(1, 2, 3, 4, 5);

            var result = collection.InterpolationSearch(3);
            var expected = Array.BinarySearch(collection.ToArray(), 3);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void InterpolationWithItemToTheLeftOfMidpoint()
        {
            var collection = new SortableCollection<int>(1, 2, 3, 4, 5);

            var result = collection.InterpolationSearch(2);
            var expected = Array.BinarySearch(collection.ToArray(), 2);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void InterpolationWithItemToTheRightOfMidpoint()
        {
            var collection = new SortableCollection<int>(1, 2, 3, 4, 5);

            var result = collection.InterpolationSearch(4);
            var expected = Array.BinarySearch(collection.ToArray(), 4);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void InterpolationWithMultipleMissingKeysSmallerThanMinimum()
        {
            const int NumberOfChecks = 10000;
            const int NumberOfElements = 1000;

            var elements = new int[NumberOfElements];

            for (int i = 0; i < NumberOfElements; i++)
            {
                elements[i] = Random.Next(int.MinValue / 2, int.MaxValue / 2);
            }

            Array.Sort(elements);

            var collection = new SortableCollection<int>(elements);

            for (int i = 0; i < NumberOfChecks; i++)
            {
                var item = Random.Next(int.MinValue, collection.Items[0]);

                int result = collection.InterpolationSearch(item);

                Assert.AreEqual(-1, result);
            }
        }

        [TestMethod]
        public void InterpolationWithMultipleMissingKeysLargerThanMaximum()
        {
            const int NumberOfChecks = 10000;
            const int NumberOfElements = 1000;

            var elements = new int[NumberOfElements];

            for (int i = 0; i < NumberOfElements; i++)
            {
                elements[i] = Random.Next(int.MinValue / 2, int.MaxValue / 2);
            }

            Array.Sort(elements);

            var collection = new SortableCollection<int>(elements);

            for (int i = 0; i < NumberOfChecks; i++)
            {
                var item = Random.Next(collection.Items[collection.Count - 1], int.MaxValue);

                int result = collection.InterpolationSearch(item);

                Assert.AreEqual(-1, result);
            }
        }

        [TestMethod]
        public void InterpolationWithItemAtStart()
        {
            const int NumberOfElements = 1000;
            int start = -100;

            var elements = new int[NumberOfElements];

            for (int i = 0; i < NumberOfElements; i++)
            {
                elements[i] = start++;
            }

            Array.Sort(elements);

            var collection = new SortableCollection<int>(elements);


            int expected = 0;
            int result = collection.InterpolationSearch(-100);

            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void InterpolationWithItemAtEnd()
        {
            const int NumberOfElements = 1000;
            int start = 100;

            var elements = new int[NumberOfElements];

            for (int i = 0; i < NumberOfElements; i++)
            {
                elements[i] = start--;
            }

            Array.Sort(elements);

            var collection = new SortableCollection<int>(elements);


            int expected = 999;
            int result = collection.InterpolationSearch(100);

            Assert.AreEqual(expected, result);

        }
    }
}
