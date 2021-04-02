using LeetCode.Q801_900;
using NUnit.Framework;

namespace LeetCode.Test.Q801_900
{
    class Q819Test
    {
        [Test]
        public void Test()
        {
            string result = new Q819().MostCommonWord("Bob hit a ball, the hit BALL flew far after it was hit.", new[] { "hit" });
            Assert.AreEqual("ball", result);
        }
    }
}