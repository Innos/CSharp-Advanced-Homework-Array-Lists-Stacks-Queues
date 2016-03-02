namespace _06LinkedStackTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using _05LinkedStack;

    [TestClass]
    public class ToArrayTests
    {
        [TestMethod]
        public void LinkedStackToArray_WithEmptyStack_ShouldReturnEmptyArray()
        {
            var stack = new LinkedStack<int>();
            int[] array = stack.ToArray();
            Assert.AreEqual(0, array.Length, "Expected length did not match!");
        }

        [TestMethod]
        public void LinkedStackToArray_WithStackWithElements_ShouldReturnAnArrayWithCorrectLength()
        {
            var stack = new LinkedStack<int>();
            for (int i = 0; i < 1000; i++)
            {
                stack.Push(i);
            }
            int[] array = stack.ToArray();
            Assert.AreEqual(1000, array.Length, "Expected length did not match!");
        }

        [TestMethod]
        public void LinkedStackToArray_WithStackWithElements_ShouldReturnAnArrayWithCorrectElements()
        {
            var stack = new LinkedStack<int>();
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
