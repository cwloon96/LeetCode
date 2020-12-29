using LeetCode.Q1001_1100;
using NUnit.Framework;

namespace LeetCode.Test.Q1001_1100
{
    public class Q1089Test
    {
        [Test]
        public void Test()
        {
            int[] arr = new[] { 1, 0, 2, 3, 0, 4, 5, 0 };
            new Q1089().DuplicateZeros(arr);

            Assert.AreEqual(1, arr[0]);
            Assert.AreEqual(0, arr[1]);
            Assert.AreEqual(0, arr[2]);
            Assert.AreEqual(2, arr[3]);
            Assert.AreEqual(3, arr[4]);
            Assert.AreEqual(0, arr[5]);
            Assert.AreEqual(0, arr[6]);
            Assert.AreEqual(4, arr[7]);
        }
    }
}