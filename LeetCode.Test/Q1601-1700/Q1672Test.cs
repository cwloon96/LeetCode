using LeetCode.Q1601_1700;
using NUnit.Framework;

namespace LeetCode.Test.Q1601_1700
{
    class Q1672Test
    {
        [Test]
        public void Test()
        {
            int result = new Q1672().MaximumWealth(new[] { new[] { 1, 2, 3 }, new[] { 1, 2, 3 } });

            Assert.AreEqual(6, result);
        }
    }
}