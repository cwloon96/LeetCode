using LeetCode.Q1_100;
using NUnit.Framework;
using System.Collections.Generic;

namespace LeetCode.Test.Q1_100
{
    class Q78Test
    {
        [Test]
        public void Test()
        {
            IList<IList<int>> result = new Q78().Subsets(new[] { 1, 2, 3 });

            IList<IList<int>> expected = new List<IList<int>>
            {
                new List<int> { },
                new List<int> { 1 },
                new List<int> { 2 },
                new List<int> { 1, 2 },
                new List<int> { 3 },
                new List<int> { 1, 3 },
                new List<int> { 2, 3 },
                new List<int> { 1, 2, 3 },
            };

            CollectionAssert.AreEquivalent(expected, result);
        }
    }
}