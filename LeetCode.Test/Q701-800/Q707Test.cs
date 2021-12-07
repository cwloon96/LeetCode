using LeetCode.Q701_800;
using NUnit.Framework;

namespace LeetCode.Test.Q701_800
{
    class Q707Test
    {
        [Test]
        public void Test()
        {
            var list = new MyLinkedList();
            list.AddAtHead(84);
            list.AddAtTail(2);
            list.AddAtTail(39);
            Assert.AreEqual(-1, list.Get(3));
            Assert.AreEqual(2, list.Get(1));

            list.AddAtTail(42);
            list.AddAtIndex(1, 80);
            list.AddAtHead(14);
            list.AddAtHead(1);
            list.AddAtTail(53);
            list.AddAtTail(98);
            list.AddAtTail(19);
            list.AddAtTail(12);
            Assert.AreEqual(84, list.Get(2));

            list.AddAtHead(16);
            list.AddAtHead(33);
            list.AddAtIndex(4, 17);
            list.AddAtIndex(6, 8);
            list.AddAtHead(37);
            list.AddAtTail(43);
            list.DeleteAtIndex(11);
            list.AddAtHead(80);
            list.AddAtHead(31);
            list.AddAtIndex(13, 23);
            list.AddAtTail(17);
            Assert.AreEqual(16, list.Get(4));

            list.AddAtIndex(10, 0);
            list.AddAtTail(21);
            list.AddAtHead(73);
            list.AddAtHead(22);
            list.AddAtIndex(24, 37);
            list.AddAtTail(14);
            list.AddAtHead(97);
            list.AddAtHead(8);
            Assert.AreEqual(37, list.Get(6));

            list.DeleteAtIndex(17);
            list.AddAtTail(50);
            list.AddAtTail(28);
            list.AddAtHead(76);
            list.AddAtTail(79);
            Assert.AreEqual(23, list.Get(18));

            list.DeleteAtIndex(30);
            list.AddAtTail(5);
            list.AddAtHead(9);
            list.AddAtTail(83);
            list.DeleteAtIndex(3);
            list.AddAtTail(40);
            list.DeleteAtIndex(26);
            list.AddAtIndex(20, 90);
            list.DeleteAtIndex(30);
            list.AddAtTail(40);
            list.AddAtHead(56);
            list.AddAtIndex(15, 23);
            list.AddAtHead(51);
            list.AddAtHead(21);
            Assert.AreEqual(19, list.Get(26));

            list.AddAtHead(83);
            Assert.AreEqual(17, list.Get(30));

            list.AddAtHead(12);
            list.DeleteAtIndex(8);
            Assert.AreEqual(56, list.Get(4));

            list.AddAtHead(20);
            list.AddAtTail(45);
            Assert.AreEqual(31, list.Get(10));

            list.AddAtHead(56);
            Assert.AreEqual(17, list.Get(18));

            list.AddAtTail(33);
            Assert.AreEqual(12, list.Get(2));

            list.AddAtTail(70);
            list.AddAtHead(57);
            list.AddAtIndex(31, 24);
            list.AddAtIndex(16, 92);
            list.AddAtHead(40);
            list.AddAtHead(23);
            list.DeleteAtIndex(26);
            Assert.AreEqual(40, list.Get(1));

            list.AddAtHead(92);
            list.AddAtIndex(3, 78);
            list.AddAtTail(42);
            Assert.AreEqual(37, list.Get(18));

            list.AddAtIndex(39, 9);
            Assert.AreEqual(76, list.Get(13));

            list.AddAtIndex(33, 17);
            Assert.AreEqual(42, list.Get(51));

            list.AddAtIndex(18, 95);
            list.AddAtIndex(18, 33);
            list.AddAtHead(80);
            list.AddAtHead(21);
            list.AddAtTail(7);
            list.AddAtIndex(17, 46);
            Assert.AreEqual(80, list.Get(33));

            list.AddAtHead(60);
            list.AddAtTail(26);
            list.AddAtTail(4);
            list.AddAtHead(9);
            Assert.AreEqual(43, list.Get(45));

            list.AddAtTail(38);
            list.AddAtHead(95);
            list.AddAtTail(78);

            Assert.AreEqual(40, list.Get(54));
            list.AddAtIndex(42, 86);
        }

        [Test]
        public void Test2()
        {
            var list = new MyLinkedList();
            list.AddAtHead(2);
            list.DeleteAtIndex(1);
            list.AddAtHead(2);
            list.AddAtHead(7);
            list.AddAtHead(3);
            list.AddAtHead(2);
            list.AddAtHead(5);
            list.AddAtTail(5);
            Assert.AreEqual(2, list.Get(5));
            list.DeleteAtIndex(6);
            list.DeleteAtIndex(4);
        }
    }
}