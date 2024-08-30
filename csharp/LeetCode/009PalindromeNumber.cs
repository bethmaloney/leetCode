using System;

namespace LeetCode
{
    // Given an integer x, return true if x is palindrome integer.
    public class PalindromeNumber
    {
        public bool IsPalindrome(int number)
        {
            if (number < 0)
            {
                return false;
            }

            var numberAsString = number.ToString();

            for (int i = 0; i < numberAsString.Length; i++)
            {
                if (numberAsString[i] != numberAsString[numberAsString.Length - i - 1])
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsPalindromeWithoutString(int number)
        {
            if (number < 0)
            {
                return false;
            }
            else if (number == 0)
            {
                return true;
            }

            var length = (int)Math.Floor(Math.Log10(number)) + 1;

            for (int i = 0; i < length / 2; i++)
            {
                var leftDigit = (number % (int)Math.Pow(10, length - i)) / (int)Math.Pow(10, length - i - 1);
                var rightDigit = (number / (int)Math.Pow(10, i) * (int)Math.Pow(10, i)) % (int)Math.Pow(10, i + 1);

                if (leftDigit != rightDigit)
                {
                    return false;
                }
            }
            
            return true;
        }
    }
}