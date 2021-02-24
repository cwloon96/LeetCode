using LeetCode.Q1701_1800;
using NUnit.Framework;

namespace LeetCode.Test.Q1701_1800
{
    class Q1768Test
    {
        [Test]
        public void Test()
        {
            string result = new Q1768().MergeAlternately("abc", "pqr");
            Assert.AreEqual("apbqcr", result);
        }
    }
}