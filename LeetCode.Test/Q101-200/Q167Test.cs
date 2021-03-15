using LeetCode.Q101_200;
using NUnit.Framework;

namespace LeetCode.Test.Q101_200
{
    class Q167Test
    {
        [Test]
        public void Test()
        {
            int[] result = new Q167().TwoSum(new int[] { -1, 0 }, -1);
            CollectionAssert.AreEqual(new[] { 1, 2 }, result);
        }
    }
}