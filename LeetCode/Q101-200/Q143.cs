using LeetCode.Common.Models;
using System;
using System.Collections.Generic;

namespace LeetCode.Q101_200
{
    public class Q143
    {
        public void ReorderList(ListNode head)
        {
            Stack<ListNode> stack = new Stack<ListNode>();
            ListNode copy = head;
            while (copy != null)
            {
                stack.Push(copy);
                copy = copy.next;
            }

            int size = stack.Count;

            while (stack.Count > Math.Ceiling((double)size / 2))
            {
                ListNode temp = head.next;
                head.next = stack.Pop();
                head.next.next = temp;
                head = head.next.next;
            }

            if (head != null)
                head.next = null;
        }
    }
}