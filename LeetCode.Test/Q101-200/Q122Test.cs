using LeetCode.Q101_200;
using NUnit.Framework;

namespace LeetCode.Test.Q101_200
{
    class Q122Test
    {
        [Test]
        public void Test()
        {
            int result = new Q122().MaxProfit(new int[] { 1, 2, 3, 4, 5 });
            Assert.AreEqual(4, result);
        }
    }
}