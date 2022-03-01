using System.Collections.Generic;

namespace LeetCode
{
    //Definition for singly-linked list. Used by a few Leet Code questions
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
        
        public static ListNode ConvertArrayToListNode(int[] array)
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

        public static int[] ConvertListNodeToArray(ListNode list)
        {
            if (list is null)
            {
                return new int[0];
            }
            
            var array = new List<int>();
            
            while (list != null)
            {
                array.Add(list.val);
                list = list.next;
            }

            return array.ToArray();
        }
    }
}
