using LeetCode.Q101_200;
using NUnit.Framework;
using System.Collections.Generic;

namespace LeetCode.Test.Q101_200
{
    class Q131Test
    {
        [Test]
        public void Test()
        {
            IList<IList<string>> result = new Q131().Partition("aab");
            IList<IList<string>> expected = new List<IList<string>>
            {
                new List<string> { "a", "a", "b"},
                new List<string> { "aa", "b"}
            };

            CollectionAssert.AreEqual(expected, result);
        }
    }
}