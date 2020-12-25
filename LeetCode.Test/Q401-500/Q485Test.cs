using LeetCode.Q401_500;
using NUnit.Framework;

namespace LeetCode.Test.Q401_500
{
    public class Q485Test
    {
        [Test]
        public void Test()
        {
            int result = new Q485().FindMaxConsecutiveOnes(new[] { 1, 1, 0, 1, 1, 1 });
            Assert.AreEqual(3, result);
        }
    }
}