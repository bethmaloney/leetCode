using System;

namespace LeetCode
{
    // Given a sorted array of distinct integers and a target value, return the index if the target is found.
    // If not, return the index where it would be if it were inserted in order.
    // You must write an algorithm with O(log n) runtime complexity.
    public class SearchInsertPosition
    {
        public int SlowSearchInsert(int[] nums, int target)
        {
            for (var index = 0; index < nums.Length; index++)
            {
                var num = nums[index];

                if (num >= target)
                {
                    return index;
                }
            }

            return nums.Length;
        }

        private int BinarySearchRec(ArraySegment<int> nums, int target)
        {
            if (nums.Count == 1 && target > nums[0])
            {
                return nums.Offset + 1;
            }
            
            if (nums.Count == 1 && target < nums[0])
            {
                return nums.Offset;
            }

            if (nums.Count == 1 && nums[0] == target)
            {
                return nums.Offset;
            }
            
            if (nums[nums.Count / 2] == target)
            {
                return nums.Offset + nums.Count / 2;
            }
            
            if (nums[nums.Count / 2] > target)
            {
                return BinarySearchRec(nums.Slice(0, nums.Count / 2), target);
            }
            
            if (nums[nums.Count / 2] < target)
            {
                return BinarySearchRec(nums.Slice(nums.Count / 2), target);
            }

            throw new InvalidOperationException();
        }

        public int BinarySearchInsert(int[] nums, int target)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            
            return BinarySearchRec(nums, target);
        }
    }
}