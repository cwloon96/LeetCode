using LeetCode.Common.Models;

namespace LeetCode.Q1_100
{
    public class Q21
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null && l2 == null)
                return null;

            if (l1 == null || (l1 != null && l2 != null && l1.val > l2.val))
                return new ListNode(l2.val, MergeTwoLists(l1, l2?.next));
            else
                return new ListNode(l1.val, MergeTwoLists(l1.next, l2));
        }
    }
}