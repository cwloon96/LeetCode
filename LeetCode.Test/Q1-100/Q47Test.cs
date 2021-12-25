using LeetCode.Q1_100;
using NUnit.Framework;
using System.Collections.Generic;

namespace LeetCode.Test.Q1_100
{
    class Q47Test
    {
        [Test]
        public void Test()
        {
            IList<IList<int>> result = new Q47().PermuteUnique(new[] { 1, 1, 2 });

            Assert.AreEqual(new List<IList<int>>
            {
                new List<int> { 1, 1, 2 },
                new List<int> { 1, 2, 1 },
                new List<int> { 2, 1, 1 },
            }, result);
        }
    }
}