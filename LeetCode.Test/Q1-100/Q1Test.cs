using LeetCode.Q1_100;
using NUnit.Framework;

namespace LeetCode.Test.Q1_100
{
    class Q1Test
    {
        [Test]
        public void Test()
        {
            int[] result = new Q1().TwoSum(new[] { 2, 7, 11, 15 }, 9);

            Assert.AreEqual(new int[2] { 0, 1 }, result);
        }
    }
}