using LeetCode.Q1001_1100;
using NUnit.Framework;

namespace LeetCode.Test.Q1001_1100
{
    class Q1029Test
    {
        [Test]
        public void Test()
        {
            int result = new Q1029().TwoCitySchedCost(new[] {
                new[] { 10, 20 },
                new[] { 30, 200 },
                new[] { 400, 50 },
                new[] { 30, 20 },
            });
            Assert.AreEqual(110, result);
        }
    }
}