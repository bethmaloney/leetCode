using System;
using System.Collections.Generic;

namespace LeetCode
{
    // Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    public class TwoSum
    {
        public int[] GetIndices(int[] nums, int target)
        {
            {
                var dic = new Dictionary<int, int>();

                for (var i = 0; i < nums.Length; i++)
                {
                    var complementary = target - nums[i];
                    if (dic.TryGetValue(complementary, out var index))
                    {
                        return new[] { i, index };
                    }

                    if (!dic.ContainsKey(nums[i]))
                    {
                        dic.Add(nums[i], i);
                    }
                }

                throw new NotImplementedException();
            }
        }
    }
}