namespace LeetCode
{
    public class AddTwoNumbers
    {
        public ListNode CalculateResult(ListNode l1, ListNode l2)
        {
            var currentl1 = l1;
            var currentl2 = l2;
            var carry = 0;
            ListNode totalList = null;
            ListNode currentTotalNode = null;

            while (currentl1 != null || currentl2 != null || carry != 0)
            {
                if (currentTotalNode is null)
                {
                    totalList = new ListNode();
                    currentTotalNode = totalList;
                }
                else
                {
                    currentTotalNode.next = new ListNode();
                    currentTotalNode = currentTotalNode.next; 
                }
                
                var total = (currentl1?.val ?? 0) + (currentl2?.val ?? 0) + carry;
                carry = total / 10;
                total %= 10;
                
                currentTotalNode.val = total;
                currentl1 = currentl1?.next;
                currentl2 = currentl2?.next;
            }

            return totalList;
        }
    }
}