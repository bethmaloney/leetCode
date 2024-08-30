using LeetCode;
using NUnit.Framework;

namespace LeetCodeTest
{
    public class LongestSubstring
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("abcabcbb", 3)]
        [TestCase("", 0)]
        [TestCase(null, 0)]
        public void Inputs_Return_CorrectLength(string input, int length)
        {
            var test = new LeetCode.LongestSubstring();
            var result = test.LengthOfLongestSubstring(input);
            
            Assert.AreEqual(length, result);
        }
    }
}