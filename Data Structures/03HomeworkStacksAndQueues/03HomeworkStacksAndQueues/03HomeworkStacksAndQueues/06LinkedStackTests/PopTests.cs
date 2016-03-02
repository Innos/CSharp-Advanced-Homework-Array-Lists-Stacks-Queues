namespace _06LinkedStackTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using _05LinkedStack;

    [TestClass]
    public class PopTests
    {
        [ExpectedException(typeof(InvalidOperationException))]
        [TestMethod]
        public void LinkedStackPop_WithoutElements_ShouldThrowCorrectException()
        {
            var stack = new LinkedStack<int>();

            stack.Pop();
        }

        [TestMethod]
        public void LinkedStackPop_ShouldDecreaseCount()
        {
            var stack = new LinkedStack<int>();
            stack.Push(10);

            Assert.AreEqual(1, stack.Count, "Expected count did not match!");
            stack.Pop();

            Assert.AreEqual(0, stack.Count, "Expected count did not match!");
        }

        [TestMethod]
        public void LinkedStackPop_ShouldReturnCorrectElement()
        {
            var stack = new LinkedStack<int>();
            stack.Push(10);

            Assert.AreEqual(10, stack.Pop(), "Expected element did not match!");
        }

        [TestMethod]
        public void LinkedStackPop_With1000Elements_ShouldReturnCorrectElementsAndReduceCountCorrectly()
        {
            var stack = new LinkedStack<int>();
            Assert.AreEqual(0, stack.Count, "Expected count did not match!");
            for (int i = 0; i < 1000; i++)
            {
                stack.Push(i);
            }
            Assert.AreEqual(1000, stack.Count, "Expected count did not match!");
            for (int i = 999; i >= 0; i--)
            {
                var element = stack.Pop();
                Assert.AreEqual(i, element, "Expected element did not match!");
                Assert.AreEqual(i, stack.Count, "Expected count did not match!");
            }
        }
    }
}
