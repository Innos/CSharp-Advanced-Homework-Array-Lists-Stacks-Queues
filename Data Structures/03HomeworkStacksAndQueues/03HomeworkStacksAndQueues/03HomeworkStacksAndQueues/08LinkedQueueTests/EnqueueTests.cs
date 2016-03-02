namespace LinkedQueueTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using _07LinkedQueue;

    [TestClass]
    public class EnqueueTests
    {
        [TestMethod]
        public void LinkedQueueEnqueue_ShouldIncreaseCount()
        {
            var queue = new LinkedQueue<int>();
            Assert.AreEqual(0, queue.Count, "Expected count did not match!");
            queue.Enqueue(10);
            Assert.AreEqual(1, queue.Count, "Expected count did not match!");
        }

        //correctness of added element is tested in Dequeue tests

        [TestMethod]
        public void LinkedQueueEnqueue_With1000Elements_ShouldCorrectlyIncreaseCount()
        {
            var queue = new LinkedQueue<int>();
            Assert.AreEqual(0, queue.Count, "Expected count did not match!");
            for (int i = 1; i <= 1001; i++)
            {
                queue.Enqueue(i);
                Assert.AreEqual(i, queue.Count, "Expected count did not match!");
            }
        }
    }
}
