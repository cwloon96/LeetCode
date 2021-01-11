using LeetCode.Q1001_1100;
using NUnit.Framework;
using System.Collections.Generic;

namespace LeetCode.Test.Q1001_1100
{
    class Q1431Test
    {
        [Test]
        public void Test()
        {
            IList<bool> result = new Q1431().KidsWithCandies(new[] { 2, 3, 5, 1, 3 }, 3);

            Assert.AreEqual(true, result[0]);
            Assert.AreEqual(true, result[1]);
            Assert.AreEqual(true, result[2]);
            Assert.AreEqual(false, result[3]);
            Assert.AreEqual(true, result[4]);
        }
    }
}