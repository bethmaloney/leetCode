using LeetCode;
using NUnit.Framework;

namespace LeetCodeTest
{
    [TestFixture]
    public class SearchInsertPositionTest
    {
        [TestCaseSource(nameof(_data))]
        public int SlowSearchInsert_ShouldReturn_InsertLocation(int[] nums, int target)
        {
            var searchInsert = new SearchInsertPosition();
            return searchInsert.SlowSearchInsert(nums, target);
        }
        
        [TestCaseSource(nameof(_data))]
        public int BinarySearchInsert_ShouldReturn_InsertLocation(int[] nums, int target)
        {
            var searchInsert = new SearchInsertPosition();
            return searchInsert.BinarySearchInsert(nums, target);
        }

        private static TestCaseData[] _data =
        {
            new TestCaseData(new[] {1,3,5,6}, 5)
                .Returns(2),
            new TestCaseData(new[] {1,3,5,6}, 2)
                .Returns(1),
            new TestCaseData(new[] {1,3,5,6}, 7)
                .Returns(4),
            new TestCaseData(new[] {1,3,5}, 5)
                .Returns(2),
            new TestCaseData(new int[0], 0)
            .Returns(0)
        };
    }
}