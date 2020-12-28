using LeetCode.Q901_1000;
using NUnit.Framework;

namespace LeetCode.Test.Q901_1000
{
    public class Q977Test
    {
        [Test]
        public void Test()
        {
            int[] result = new Q977().SortedSquares(new[] { -4, -1, 0, 3, 10 });

            Assert.AreEqual(result[0], 0);
            Assert.AreEqual(result[1], 1);
            Assert.AreEqual(result[2], 9);
            Assert.AreEqual(result[3], 16);
            Assert.AreEqual(result[4], 100);
        }
    }
}