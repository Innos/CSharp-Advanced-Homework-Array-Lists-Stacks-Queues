namespace _04ArrayStackTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using _03ImplementAnArrayBasedStack;

    [TestClass]
    public class PushTests
    {
        [TestMethod]
        public void ArrayStackPush_ShouldIncreaseCount()
        {
            var stack = new ArrayStack<int>();
            Assert.AreEqual(0, stack.Count, "Expected count did not match!");
            stack.Push(10);
            Assert.AreEqual(1, stack.Count, "Expected count did not match!");
        }

        //correctness of added element is tested in Pop tests

        [TestMethod]
        public void ArrayStackPush_With1000Elements_ShouldCorrectlyIncreaseCount()
        {
            var stack = new ArrayStack<int>();
            Assert.AreEqual(0, stack.Count, "Expected count did not match!");
            for (int i = 1; i <= 1001; i++)
            {
                stack.Push(i);
                Assert.AreEqual(i, stack.Count, "Expected count did not match!");
            }
        }
    }
}
