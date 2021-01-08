using LeetCode.Q1_100;
using NUnit.Framework;

namespace LeetCode.Test.Q1_100
{
    class Q4Test
    {
        [Test]
        public void Test()
        {
            double result = new Q4().FindMedianSortedArrays(new[] { 1, 3 }, new[] { 2 });

            Assert.AreEqual(2, result);
        }
    }
}