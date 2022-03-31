using LeetCode.Q1601_1700;
using NUnit.Framework;

namespace LeetCode.Test.Q1601_1700
{
    class Q1675Test
    {
        [Test]
        public void Test()
        {
            int result = new Q1675().MinimumDeviation(new[] { 1, 2, 3, 4 });

            Assert.AreEqual(1, result);
        }
    }
}