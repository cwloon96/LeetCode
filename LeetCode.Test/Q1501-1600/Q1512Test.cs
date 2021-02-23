using LeetCode.Q1501_1600;
using NUnit.Framework;

namespace LeetCode.Test.Q1501_1600
{
    class Q1512Test
    {
        [Test]
        public void Test()
        {
            int result = new Q1512().NumIdenticalPairs(new[] { 1, 2, 3, 1, 1, 3 });
            Assert.AreEqual(4, result);
        }
    }
}