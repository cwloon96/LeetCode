using LeetCode.Q1301_1400;
using NUnit.Framework;

namespace LeetCode.Test.Q1301_1400
{
    public class Q1395Test
    {
        [Test]
        public void Test()
        {
            int result = new Q1395().NumTeams(new[] { 2, 5, 3, 4, 1 });
            Assert.AreEqual(3, result);
        }
    }
}