using LeetCode.Q1601_1700;
using NUnit.Framework;

namespace LeetCode.Test.Q1601_1700
{
    class Q1624Test
    {
        [Test]
        public void Test()
        {
            int result = new Q1624().MaxLengthBetweenEqualCharacters("abca");

            Assert.AreEqual(2, result);
        }
    }
}