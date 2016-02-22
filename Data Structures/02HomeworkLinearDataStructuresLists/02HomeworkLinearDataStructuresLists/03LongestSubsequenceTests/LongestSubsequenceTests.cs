namespace _03LongestSubsequenceTests
{
    using System.Collections.Generic;
    using _03LongestSubsequence;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class LongestSubsequenceTests
    {
        [TestMethod]
        public void FindLongestSubsequence_WithDifferentElements_ShouldReturnFirst()
        {
            var list = new List<int>() { 1, 2, 3 };
            var result = LongestSubsequence.FindLongestSubsequence(list);

            CollectionAssert.AreEqual(new List<int>() { 1 }, result);
        }

        [TestMethod]
        public void FindLongestSubsequence_WithSameElements_ShouldReturnBiggestSubsequence()
        {
            var list = new List<int>() { 1, 1, 2, 2, 2, 3, 3 };
            var result = LongestSubsequence.FindLongestSubsequence(list);

            CollectionAssert.AreEqual(new List<int>() { 2, 2, 2 }, result);
        }

        [TestMethod]
        public void FindLongestSubsequence_WithSameLengthSubsequences_ShouldReturnLeftmostSubsequence()
        {
            var list = new List<int>() { 1, 1, 2, 2, 3, 3 };
            var result = LongestSubsequence.FindLongestSubsequence(list);

            CollectionAssert.AreEqual(new List<int>() { 1, 1 }, result);
        }

        [TestMethod]
        public void FindLongestSubsequence_WithRandomElements_ShouldReturnCorrectSubsequence()
        {
            var list = new List<int>() { 12, 2, 7, 4, 3, 3, 8 };
            var result = LongestSubsequence.FindLongestSubsequence(list);

            CollectionAssert.AreEqual(new List<int>() { 3, 3 }, result);
        }
    }
}
