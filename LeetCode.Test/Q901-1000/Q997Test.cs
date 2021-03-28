using LeetCode.Q901_1000;
using NUnit.Framework;

namespace LeetCode.Test.Q901_1000
{
    class Q997Test
    {
        [Test]
        public void Test()
        {
            int result = new Q997().FindJudge(2, new int[][] { new int[] { 1, 2 } });

            Assert.AreEqual(2, result);
        }
    }
}