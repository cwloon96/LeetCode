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

            Assert.AreEqual(expected, result);
        }
    }
}