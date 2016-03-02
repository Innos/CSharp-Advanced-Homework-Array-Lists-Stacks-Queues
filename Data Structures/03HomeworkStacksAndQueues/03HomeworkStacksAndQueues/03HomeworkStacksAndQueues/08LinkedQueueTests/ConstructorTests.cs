namespace LinkedQueueTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using _07LinkedQueue;

    [TestClass]
    public class ConstructorTests
    {
        [TestMethod]
        public void LinkedQueue_Constructor_ShouldConstructEmptyStack()
        {
            var queue = new LinkedQueue<int>();
            Assert.AreEqual(0, queue.Count, "Count was not 0!");
        }
    }
}
