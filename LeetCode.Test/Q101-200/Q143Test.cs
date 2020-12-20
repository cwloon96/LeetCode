using LeetCode.Common.Models;
using LeetCode.Q101_200;
using NUnit.Framework;

namespace LeetCode.Test.Q101_200
{
    public class Q143Test
    {
        [Test]
        public void Test()
        {
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);

            new Q143().ReorderList(head);

            Assert.AreEqual(1, head.val);
            Assert.AreEqual(4, head.next.val);
            Assert.AreEqual(2, head.next.next.val);
            Assert.AreEqual(3, head.next.next.next.val);
        }
    }
}