namespace _06LinkedStackTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using _05LinkedStack;

    [TestClass]
    public class ConstructorTests
    {
        [TestMethod]
        public void LinkedStack_Constructor_ShouldConstructEmptyStack()
        {
            var stack = new LinkedStack<int>();
            Assert.AreEqual(0, stack.Count, "Count was not 0!");
        }
    }
}
