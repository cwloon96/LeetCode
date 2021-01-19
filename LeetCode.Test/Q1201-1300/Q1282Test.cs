using LeetCode.Q1201_1300;
using NUnit.Framework;
using System.Collections.Generic;

namespace LeetCode.Test.Q1201_1300
{
    public class Q1282Test
    {
        [Test]
        public void Test()
        {
            IList<IList<int>> result = new Q1282().GroupThePeople(new[] { 3, 3, 3, 3, 3, 1, 3 });

            List<IList<int>> expected = new List<IList<int>>
            {
                new List<int> { 0, 1, 2 },
                new List<int> { 5 },
                new List<int> { 3, 4, 6 },
            };

            CollectionAssert.AreEquivalent(expected, result);
        }

        [Test]
        public void Test2()
        {
            IList<IList<int>> result = new Q1282().GroupThePeople(new[] { 2, 1, 3, 3, 3, 2 });

            List<IList<int>> expected = new List<IList<int>>
            {
                new List<int> { 1 },
                new List<int> { 0, 5 },
                new List<int> { 2, 3, 4 },
            };

            CollectionAssert.AreEquivalent(expected, result);
        }
    }
}