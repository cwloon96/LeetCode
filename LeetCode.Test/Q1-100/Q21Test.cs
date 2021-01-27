using LeetCode.Common.Models;
using LeetCode.Q1_100;
using NUnit.Framework;

namespace LeetCode.Test.Q1_100
{
    class Q21Test
    {
        [Test]
        public void Test()
        {
            ListNode l1 = new ListNode(1);
            l1.next = new ListNode(2);
            l1.next.next = new ListNode(4);

            ListNode l2 = new ListNode(1);
            l2.next = new ListNode(3);
            l2.next.next = new ListNode(4);

            ListNode result = new Q21().MergeTwoLists(l1, l2);
            Assert.AreEqual(1, result.val);
            Assert.AreEqual(1, result.next.val);
            Assert.AreEqual(2, result.next.next.val);
            Assert.AreEqual(3, result.next.next.next.val);
            Assert.AreEqual(4, result.next.next.next.next.val);
            Assert.AreEqual(4, result.next.next.next.next.next.val);
        }
    }
}