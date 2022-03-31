using LeetCode.Q1301_1400;
using NUnit.Framework;

namespace LeetCode.Test.Q1301_1400
{
    class Q1319Test
    {
        [Test]
        public void Test()
        {
            int result = new Q1319().MakeConnected(5, new[] { 
                new[] { 0, 1 },
                new[] { 0, 2 },
                new[] { 1, 2 },
                new[] { 2, 3 },
            });

            Assert.AreEqual(1, result);
        }
    }
}