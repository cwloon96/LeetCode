using LeetCode.Q1_100;
using NUnit.Framework;

namespace LeetCode.Test.Q1_100
{
    class Q62Test
    {
        [Test]
        public void Test()
        {
            int result = new Q62().UniquePaths(7, 3);

            Assert.AreEqual(28, result);
        }
    }
}