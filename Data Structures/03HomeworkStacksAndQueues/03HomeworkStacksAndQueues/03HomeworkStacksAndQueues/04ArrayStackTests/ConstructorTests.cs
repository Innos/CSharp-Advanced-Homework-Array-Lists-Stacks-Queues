namespace _04ArrayStackTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using _03ImplementAnArrayBasedStack;

    [TestClass]
    public class ConstructorTests
    {
        [TestMethod]
        public void ArrayStack_Constructor_ShouldConstructEmptyStack()
        {
            var stack = new ArrayStack<int>();
            Assert.AreEqual(0, stack.Count, "Count was not 0!");
        }

        [TestMethod]
        public void ArrayStack_ConstructorWithGivenCapacity_ShouldConstructEmptyStackWithGivenCapacity()
        {
            var stack = new ArrayStack<int>(5);
            Assert.AreEqual(5, stack.Capacity, "Expected Capacity did not match!");
        }

        [TestMethod]
        public void ArrayStack_ConstructorWithoutGivenCapacity_ShouldConstructEmptyStackWithDefaultCapacity()
        {
            var stack = new ArrayStack<string>();
            Assert.AreEqual(16, stack.Capacity, "Expected Capacity did not match!");
        }
    }
}
