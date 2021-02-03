using LeetCode.Q1_100;
using NUnit.Framework;
using System.Collections.Generic;

namespace LeetCode.Test.Q1_100
{
    public class Q15Test
    {
        [Test]
        public void Test()
        {
            var result = new Q15().ThreeSum(new[] { -1, 0, 1, 2, -1, -4 });
            var expected = new List<IList<int>> { new List<int> { -1, -1, 2 }, new List<int> { -1, 0, 1 } };

            CollectionAssert.AreEqual(expected, result);
        }

        [Test]
        public void Test2()
        {
            var result = new Q15().ThreeSum(new int[0]);
            var expected = new List<IList<int>> { };

            CollectionAssert.AreEqual(expected, result);
        }
    }
}