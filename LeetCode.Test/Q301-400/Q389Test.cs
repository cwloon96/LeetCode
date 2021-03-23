using LeetCode.Q301_400;
using NUnit.Framework;

namespace LeetCode.Test.Q301_400
{
    class Q389Test
    {
        [Test]
        public void Test()
        {
            char result = new Q389().FindTheDifference("abc", "abcd");

            Assert.AreEqual('d', result);
        }
    }
}