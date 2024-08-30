using LeetCode;
using NUnit.Framework;

namespace LeetCodeTest
{
    public class MergeTwoSortedListsTest
    {
        [TestCaseSource(nameof(_data))]
        public void MergeTwoSortedLists_ShouldReturn_SortedList(int[] list1, int[] list2, int[] expectedResult)
        {
            var mergeLists = new MergeTwoSortedLists();
            var result = mergeLists.MergeTwoLists(ListNode.ConvertArrayToListNode(list1),
                ListNode.ConvertArrayToListNode(list2));

            Assert.That(ListNode.ConvertListNodeToArray(result), Is.EquivalentTo(expectedResult));
        }

        private static TestCaseData[] _data =
        {
            new TestCaseData(new[] { 1, 2, 4 }, new[] { 1, 3, 4 }, new[] { 1, 1, 2, 3, 4, 4 }),
            new TestCaseData(new int[0], new int[0], new int[0]),
            new TestCaseData(new int[0], new[] { 0 }, new[] { 0 })
        };
    }
}