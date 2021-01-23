using LeetCode.Q1_100;
using NUnit.Framework;

namespace LeetCode.Test.Q1_100
{
    class Q5Test
    {
        [Test]
        public void Test()
        {
            string result = new Q5().LongestPalindrome("babad");

            Assert.AreEqual("bab", result);
        }
    }
}