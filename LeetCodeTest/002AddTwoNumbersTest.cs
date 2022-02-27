using System.Collections.Generic;
using System.Linq;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTest
{
    public class AddTwoNumbersTest {

        private ListNode ConvertArrayToListNode(int[] array)
        {
            ListNode list = null;
            ListNode currentNode = null;

            foreach (var element in array)
            {
                if (currentNode is null)
                {
                    list = new ListNode();
                    currentNode = list;
                }
                else
                {
                    currentNode.next = new ListNode();
                    currentNode = currentNode.next;
                }
                currentNode.val = element;
            }

            return list;
        }

        private int[] ConvertListNodeToArray(ListNode list)
        {
            var array = new List<int>();
            
            while (list != null)
            {
                array.Add(list.val);
                list = list.next;
            }

            return array.ToArray();
        }

        [TestCaseSource(nameof(_data))]
        public void TwoSum_ShouldReturn_CorrectValues(int[] list1, int[] list2, int[] expectedResult)
        {
            var addNumbers = new AddTwoNumbers();
            var result = addNumbers.CalculateResult(ConvertArrayToListNode(list1), ConvertArrayToListNode(list2));
            
            Assert.That(ConvertListNodeToArray(result), Is.EquivalentTo(expectedResult));
        }
        
        private static TestCaseData[] _data = {
            new TestCaseData(new[] {2,4,3}, new[] {5,6,4}, new[] {7,0,8}),
            new TestCaseData(new[] {0}, new[] {0}, new[] {0}),
            new TestCaseData(new[] {9,9,9,9,9,9,9}, new[] {9,9,9,9}, new[] {8,9,9,9,0,0,0,1})
        };
    }
}