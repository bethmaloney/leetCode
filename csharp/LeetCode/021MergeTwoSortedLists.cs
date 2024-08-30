namespace LeetCode
{
    public class MergeTwoSortedLists
    {
        private ListNode MergeTwoListsRec(ListNode list1, ListNode list2, ListNode mergedList)
        {
            if (list1 is null && list2 is null)
            {
                return mergedList;
            }

            if (list1 == null || list1.val > list2?.val)
            {
                var newNode = new ListNode(list2.val);
                mergedList.next = newNode;
                MergeTwoListsRec(list1, list2.next, mergedList.next);
                return mergedList;
            }
            else
            {
                var newNode = new ListNode(list1.val);
                mergedList.next = newNode;
                MergeTwoListsRec(list1.next, list2, mergedList.next);
                return mergedList;
            }
        }

        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 is null)
            {
                return list2;
            }
            else if (list2 is null)
            {
                return list1;
            }

            if (list1.val > list2.val)
            {
                return MergeTwoListsRec(list1, list2.next, new ListNode(list2.val));
            }
            else
            {
                return MergeTwoListsRec(list1.next, list2, new ListNode(list1.val));
            }
        }
    }
}