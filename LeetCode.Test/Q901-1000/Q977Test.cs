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

            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(1, result[1]);
            Assert.AreEqual(9, result[2]);
            Assert.AreEqual(16, result[3]);
            Assert.AreEqual(100, result[4]);
        }
    }
}