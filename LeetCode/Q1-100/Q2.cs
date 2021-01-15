using LeetCode.Common.Models;

namespace LeetCode.Q1_100
{
    public class Q2
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            return Add(l1, l2, 0);
        }


        private ListNode Add(ListNode l1, ListNode l2, int carry)
        {
            if (l1 == null && l2 == null && carry == 0)
                return null;

            int sum = (l1?.val ?? 0) + (l2?.val ?? 0) + carry;
            return new ListNode(sum % 10, Add(l1?.next, l2?.next, sum / 10));
        }
    }
}