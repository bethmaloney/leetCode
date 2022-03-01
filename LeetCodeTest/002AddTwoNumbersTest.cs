using System.Collections.Generic;
using System.Linq;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTest
{
    public class AddTwoNumbersTest {
        
        [TestCaseSource(nameof(_data))]
        public void TwoSum_ShouldReturn_CorrectValues(int[] list1, int[] list2, int[] expectedResult)
        {
            var addNumbers = new AddTwoNumbers();
            var result = addNumbers.CalculateResult(ListNode.ConvertArrayToListNode(list1), ListNode.ConvertArrayToListNode(list2));
            
            Assert.That(ListNode.ConvertListNodeToArray(result), Is.EquivalentTo(expectedResult));
        }
        
        private static TestCaseData[] _data = {
            new TestCaseData(new[] {2,4,3}, new[] {5,6,4}, new[] {7,0,8}),
            new TestCaseData(new[] {0}, new[] {0}, new[] {0}),
            new TestCaseData(new[] {9,9,9,9,9,9,9}, new[] {9,9,9,9}, new[] {8,9,9,9,0,0,0,1})
        };
    }
}
