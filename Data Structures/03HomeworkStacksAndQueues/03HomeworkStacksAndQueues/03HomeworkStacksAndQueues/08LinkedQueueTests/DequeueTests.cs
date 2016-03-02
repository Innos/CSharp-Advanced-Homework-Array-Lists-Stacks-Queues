namespace LinkedQueueTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using _07LinkedQueue;

    [TestClass]
    public class DequeueTests
    {
        [TestClass]
        public class PopTests
        {
            [ExpectedException(typeof(InvalidOperationException))]
            [TestMethod]
            public void LinkedQueueDequeue_WithoutElements_ShouldThrowCorrectException()
            {
                var queue = new LinkedQueue<int>();

                queue.Dequeue();
            }

            [TestMethod]
            public void LinkedQueueDequeue_ShouldDecreaseCount()
            {
                var queue = new LinkedQueue<int>();
                queue.Enqueue(10);

                Assert.AreEqual(1, queue.Count, "Expected count did not match!");
                queue.Dequeue();

                Assert.AreEqual(0, queue.Count, "Expected count did not match!");
            }

            [TestMethod]
            public void LinkedQueueDequeue_ShouldReturnCorrectElement()
            {
                var queue = new LinkedQueue<int>();
                queue.Enqueue(10);

                Assert.AreEqual(10, queue.Dequeue(), "Expected element did not match!");
            }

            [TestMethod]
            public void LinkedQueueDequeue_With1000Elements_ShouldReturnCorrectElementsAndReduceCountCorrectly()
            {
                var queue = new LinkedQueue<int>();
                Assert.AreEqual(0, queue.Count, "Expected count did not match!");
                for (int i = 0; i < 1000; i++)
                {
                    queue.Enqueue(i);
                }
                Assert.AreEqual(1000, queue.Count, "Expected count did not match!");

                for (int i = 0; i < 1000; i++)
                {
                    var element = queue.Dequeue();
                    Assert.AreEqual(i, element, "Expected element did not match!");
                    Assert.AreEqual(999 - i, queue.Count, "Expected count did not match!");
                }
            }
        }
    }
}
