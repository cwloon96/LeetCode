using LeetCode.Q401_500;
using NUnit.Framework;
using System.Collections.Generic;

namespace LeetCode.Test.Q401_500
{
    class Q448Test
    {
        [Test]
        public void Test()
        {
            IList<int> result = new Q448().FindDisappearedNumbers(new[] { 4, 3, 2, 7, 8, 2, 3, 1 });
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(true, result.Contains(5));
            Assert.AreEqual(true, result.Contains(6));
        }
    }
}