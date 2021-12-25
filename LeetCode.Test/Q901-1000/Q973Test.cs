using LeetCode.Q901_1000;
using NUnit.Framework;

namespace LeetCode.Test.Q901_1000
{
    public class Q973Test
    {
        [Test]
        public void Test()
        {
            var points = new int[5][];

            points[0] = new int[] { 1, 3 };
            points[1] = new int[] { 5, -1 };
            points[2] = new int[] { -2, 4 };
            points[3] = new int[] { 3, 3 };
            points[4] = new int[] { 1, -5 };

            int[][] result = new Q973().KClosest(points, 2);

            Assert.AreEqual(1, result[0][0]);
            Assert.AreEqual(3, result[0][1]);
            Assert.AreEqual(3, result[1][0]);
            Assert.AreEqual(3, result[1][1]);
        }
    }
}