using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    // Given a string s, find the length of the longest substring without repeating characters.
    public class LongestSubstring
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }
            
            var longestString = 0;
            var slidingWindowStart = 0;
            var slidingWindowEnd = 0;
            var set = new HashSet<char>();

            while (slidingWindowEnd < s.Length)
            {
                if (set.Add(s[slidingWindowEnd]))
                {
                    slidingWindowEnd++;
                    longestString = Math.Max(longestString, slidingWindowEnd - slidingWindowStart);
                }
                else
                {
                    set.Remove(s[slidingWindowStart]);
                    slidingWindowStart++;
                }
            }
            
            return longestString;
        } 
    }
}