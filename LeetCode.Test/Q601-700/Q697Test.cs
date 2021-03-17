using LeetCode.Q601_700;
using NUnit.Framework;

namespace LeetCode.Test.Q601_700
{
    class Q697Test
    {
        [Test]
        public void Test()
        {
            int result = new Q697().FindShortestSubArray(new[] { 2, 1, 1, 2, 1, 3, 3, 3, 1, 3, 1, 3, 2 });
            Assert.AreEqual(7, result);
        }
    }
}