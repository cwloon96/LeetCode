using LeetCode.Q1_100;
using NUnit.Framework;
using System.Collections.Generic;

namespace LeetCode.Test.Q1_100
{
    class Q39Test
    {
        [Test]
        public void Test()
        {
            IList<IList<int>> result = new Q39().CombinationSum(new[] { 2, 3, 5 }, 8);

            IList<IList<int>> expected = new List<IList<int>>
            {
                new List<int> { 2, 2, 2, 2 },
                new List<int> { 2, 3, 3 },
                new List<int> { 3, 5 },
            };

            CollectionAssert.AreEquivalent(expected, result);
        }
    }
}