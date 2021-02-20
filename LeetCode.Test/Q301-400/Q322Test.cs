using LeetCode.Q301_400;
using NUnit.Framework;

namespace LeetCode.Test.Q301_400
{
    class Q322Test
    {
        [Test]
        public void Test()
        {
            int result = new Q322().CoinChange(new[] { 1, 2, 5 }, 11);

            Assert.AreEqual(3, result);
        }
    }
}