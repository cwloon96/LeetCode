using LeetCode.Q1_100;
using NUnit.Framework;

namespace LeetCode.Test.Q1_100
{
    public class Q3Test
    {
        [Test]
        public void Test()
        {
            int result = new Q3().LengthOfLongestSubstring("jbpnbwwd");
            Assert.AreEqual(4, result);
        }

        [Test]
        public void Test2()
        {
            int result = new Q3().LengthOfLongestSubstring("pwwkew");
            Assert.AreEqual(3, result);
        }
    }
}