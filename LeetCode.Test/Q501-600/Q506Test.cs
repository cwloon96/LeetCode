using LeetCode.Q501_600;
using NUnit.Framework;

namespace LeetCode.Test.Q501_600
{
    class Q506Test
    {
        [Test]
        public void Test()
        {
            string[] result = new Q506().FindRelativeRanks(new[] { 10, 3, 8, 9, 4 });
            string[] expected = new[] { "Gold Medal", "5", "Bronze Medal", "Silver Medal", "4" };
            Assert.AreEqual(expected, result);
        }
    }
}