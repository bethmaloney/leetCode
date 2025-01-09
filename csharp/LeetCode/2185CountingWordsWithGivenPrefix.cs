using System;
using System.Linq;

namespace LeetCode;

public class CountPrefix
{
    public int PrefixCount(string[] words, string pref)
    {
        var count = 0;

        foreach (var word in words)
        {
            if (word.AsSpan().StartsWith(pref)) count++;
        }

        return count;
    }
}