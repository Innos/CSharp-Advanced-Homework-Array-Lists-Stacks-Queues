namespace _04ArrayStackTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using _03ImplementAnArrayBasedStack;

    [TestClass]
    public class ToArrayTests
    {
        [TestMethod]
        public void ArrayStackToArray_WithEmptyStack_ShouldReturnEmptyArray()
        {
            var stack = new ArrayStack<int>();
            int[] array = stack.ToArray();
            Assert.AreEqual(0, array.Length, "Expected length did not match!");
        }

        [TestMethod]
        public void ArrayStackToArray_WithStackWithElements_ShouldReturnAnArrayWithCorrectLength()
        {
            var stack = new ArrayStack<int>();
            for (int i = 0; i < 1000; i++)
            {
                stack.Push(i);
            }
            int[] array = stack.ToArray();
            Assert.AreEqual(1000, array.Length, "Expected length did not match!");
        }

        [TestMethod]
        public void ArrayStackToArray_WithStackWithElements_ShouldReturnAnArrayWithCorrectElements()
        {
            var stack = new ArrayStack<int>();
            for (int i = 0; i < 1000; i++)
            {
                stack.Push(i);
            }
            int[] array = stack.ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                Assert.AreEqual(i, array[array.Length - 1 - i], "Expected element did not match!");
            }
        }
    }
}
