using LeetCode.Q201_300;
using NUnit.Framework;

namespace LeetCode.Test.Q201_300
{
    class Q231Test
    {
        [Test]
        public void TestBit()
        {
            bool result = new Q231().IsPowerOfTwo_Bit(4);
            Assert.AreEqual(true, result);
        }

        [Test]
        public void TestLoop()
        {
            bool result = new Q231().IsPowerOfTwo_Loop(4);
            Assert.AreEqual(true, result);
        }
    }
}