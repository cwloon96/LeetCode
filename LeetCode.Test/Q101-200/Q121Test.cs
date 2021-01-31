using LeetCode.Q101_200;
using NUnit.Framework;

namespace LeetCode.Test.Q101_200
{
    class Q121Test
    {
        [Test]
        public void Test()
        {
            int result = new Q121().MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 });
            Assert.AreEqual(5, result);
        }
    }
}