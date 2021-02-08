using LeetCode.Common.Models;
using LeetCode.Q1_100;
using NUnit.Framework;

namespace LeetCode.Test.Q1_100
{
    public class Q19Test
    {
        [Test]
        public void Test()
        {
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);
            head.next.next.next.next = new ListNode(5);

            ListNode result = new Q19().RemoveNthFromEnd(head, 2);

            Assert.AreEqual(1, result.val);
            Assert.AreEqual(2, result.next.val);
            Assert.AreEqual(3, result.next.next.val);
            Assert.AreEqual(5, result.next.next.next.val);
        }

        [Test]
        public void Test2()
        {
            ListNode head = new ListNode(1);

            ListNode result = new Q19().RemoveNthFromEnd(head, 1);

            Assert.AreEqual(null, result);
        }

        [Test]
        public void Test3()
        {
            ListNode head = new ListNode(1);

            ListNode result = new Q19().RemoveNthFromEnd(head, 0);

            Assert.AreEqual(1, result.val);
        }
    }
}