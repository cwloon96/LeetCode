using LeetCode.Q1001_1100;
using NUnit.Framework;

namespace LeetCode.Test.Q1001_1100
{
    class Q1480Test
    {
        [Test]
        public void Test()
        {
            int[] result = new Q1480().RunningSum(new[] { 1, 2, 3, 4 });

            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(3, result[1]);
            Assert.AreEqual(6, result[2]);
            Assert.AreEqual(10, result[3]);
        }
    }
}