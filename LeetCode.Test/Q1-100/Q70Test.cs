using LeetCode.Q1_100;
using NUnit.Framework;

namespace LeetCode.Test.Q1_100
{
    public class Q70Test
    {
        [Test]
        public void Test()
        {
            int result = new Q70().ClimbStairs(5);

            Assert.AreEqual(8, result);
        }
    }
}