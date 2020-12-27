using LeetCode.Q1_100;
using NUnit.Framework;

namespace LeetCode.Test.Q1_100
{
    class Q53Test
    {
        [Test]
        public void Test()
        {
            int result = new Q53().MaxSubArrayDP(new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });

            Assert.AreEqual(6, result);
        }

        [Test]
        public void Test2()
        {
            int result = new Q53().MaxSubArrayDAC(new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });

            Assert.AreEqual(6, result);
        }
    }
}