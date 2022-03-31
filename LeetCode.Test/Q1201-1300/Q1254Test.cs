using LeetCode.Q1201_1300;
using NUnit.Framework;

namespace LeetCode.Test.Q1201_1300
{
    public class Q1254Test
    {
        [Test]
        public void Test()
        {
            int result = new Q1254().ClosedIsland(new int[][] {
                new int[] { 1, 1, 1, 1, 1, 1, 1, 0 },
                new int[] { 1, 0, 0, 0, 0, 1, 1, 0 },
                new int[] { 1, 0, 1, 0, 1, 1, 1, 0 },
                new int[] { 1, 0, 0, 0, 0, 1, 0, 1 },
                new int[] { 1, 1, 1, 1, 1, 1, 1, 0 },
            });

            Assert.AreEqual(2, result);
        }
    }
}