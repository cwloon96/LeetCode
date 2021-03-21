using LeetCode.Q801_900;
using NUnit.Framework;

namespace LeetCode.Test.Q801_900
{
    class Q888Test
    {
        [Test]
        public void Test()
        {
            int[] result = new Q888().FairCandySwap(new[] { 1, 1 }, new[] { 2, 2 });
            CollectionAssert.AreEqual(new[] { 1, 2 }, result);
        }
    }
}