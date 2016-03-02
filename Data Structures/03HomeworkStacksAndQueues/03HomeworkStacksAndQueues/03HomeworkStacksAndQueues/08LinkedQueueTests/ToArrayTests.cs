namespace LinkedQueueTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using _07LinkedQueue;

    [TestClass]
    public class ToArrayTests
    {
        [TestMethod]
        public void LinkedQueueToArray_WithEmptyQueue_ShouldReturnEmptyArray()
        {
            var queue = new LinkedQueue<int>();
            int[] array = queue.ToArray();
            Assert.AreEqual(0, array.Length, "Expected length did not match!");
        }

        [TestMethod]
        public void LinkedQueueToArray_WithQueueWithElements_ShouldReturnAnArrayWithCorrectLength()
        {
            var queue = new LinkedQueue<int>();
            for (int i = 0; i < 1000; i++)
            {
                queue.Enqueue(i);
            }
            int[] array = queue.ToArray();
            Assert.AreEqual(1000, array.Length, "Expected length did not match!");
        }

        [TestMethod]
        public void LinkedQueueToArray_WithQueueWithElements_ShouldReturnAnArrayWithCorrectElements()
        {
            var queue = new LinkedQueue<int>();
            for (int i = 0; i < 1000; i++)
            {
                queue.Enqueue(i);
            }
            int[] array = queue.ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                Assert.AreEqual(i, array[i], "Expected element did not match!");
            }
        }
    }
}
