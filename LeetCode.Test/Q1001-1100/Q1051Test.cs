using LeetCode.Q1001_1100;
using NUnit.Framework;

namespace LeetCode.Test.Q1001_1100
{
    class Q1051Test
    {
        [Test]
        public void Test()
        {
            int result = new Q1051().HeightChecker(new[] { 1, 1, 4, 2, 1, 3 });
            Assert.AreEqual(3, result);
        }
    }
}