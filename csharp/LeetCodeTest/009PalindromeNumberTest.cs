using LeetCode;
using NUnit.Framework;

namespace LeetCodeTest
{
    public class PalindromeNumberTest {

        [TestCase(121, ExpectedResult = true)]
        [TestCase(-121, ExpectedResult = false)]
        [TestCase(10, ExpectedResult = false)]
        public bool Palindrome_ShouldReturn(int number)
        {
            var palindrome = new PalindromeNumber();
            return palindrome.IsPalindrome(number);
        }
        
        [TestCase(121, ExpectedResult = true)]
        [TestCase(-121, ExpectedResult = false)]
        [TestCase(10, ExpectedResult = false)]
        [TestCase(1001, ExpectedResult = true)]
        public bool PalindromeWithoutString_ShouldReturn(int number)
        {
            var palindrome = new PalindromeNumber();
            return palindrome.IsPalindromeWithoutString(number);
        }
    }
}