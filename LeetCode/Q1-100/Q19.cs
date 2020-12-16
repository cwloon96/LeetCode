using LeetCode.Common.Models;

namespace LeetCode.Q1_100
{
    public class Q19
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode dummy = new ListNode(-1, head);

            Remove(dummy, n);
            return dummy.next;
        }

        private int Remove(ListNode current, int n)
        {
            if (current == null)
                return 0;

            int last = Remove(current.next, n);

            if (last == n && current.next != null)
                current.next = current.next.next;

            return 1 + last;
        }
    }
}