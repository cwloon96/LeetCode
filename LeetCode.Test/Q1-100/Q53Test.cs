using LeetCode.Q1_100;
using NUnit.Framework;

namespace LeetCode.Test.Q1_100
{
    class Q53Test
    {
        [Test]
        public void TestDP()
        {
            int result = new Q53().MaxSubArrayDP(new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });

            Assert.AreEqual(6, result);
        }

        [Test]
        public void TestDP2()
        {
            int result = new Q53().MaxSubArrayDP(new[] { 4 });

            Assert.AreEqual(4, result);
        }

        [Test]
        public void TestDAC()
        {
            int result = new Q53().MaxSubArrayDAC(new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });

            Assert.AreEqual(6, result);
        }

        [Test]
        public void TestDAC2()
        {
            int result = new Q53().MaxSubArrayDAC(new[] { 4 });

            Assert.AreEqual(4, result);
        }
    }
}