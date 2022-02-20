using LeetCode.Q1201_1300;
using NUnit.Framework;

namespace LeetCode.Test.Q1201_1300
{
    public class Q1288Test
    {
        [Test]
        public void Test()
        {
            var result = new Q1288().RemoveCoveredIntervals(new[] { new[] { 1, 4 }, new[] { 3, 6 }, new[] { 2, 8 }, new[] { 2, 4 } });

            Assert.AreEqual(2, result);
        }
    }
}