using LeetCode.Q1_100;
using NUnit.Framework;
using System.Collections.Generic;

namespace LeetCode.Test.Q1_100
{
    class Q46Test
    {
        [Test]
        public void Test()
        {
            IList<IList<int>> result = new Q46().Permute(new[] { 1, 2, 3 });

            Assert.AreEqual(new List<IList<int>>
            {
                new List<int> { 1, 2, 3 },
                new List<int> { 1, 3, 2 },
                new List<int> { 2, 1, 3 },
                new List<int> { 2, 3, 1 },
                new List<int> { 3, 1, 2 },
                new List<int> { 3, 2, 1 },
            }, result);
        }
    }
}