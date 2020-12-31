using LeetCode.Q1_100;
using NUnit.Framework;

namespace LeetCode.Test.Q1_100
{
    public class Q26Test
    {
        [Test]
        public void Test()
        {
            int[] arr = new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            int result = new Q26().RemoveDuplicates(arr);

            Assert.AreEqual(5, result);
            Assert.AreEqual(0, arr[0]);
            Assert.AreEqual(1, arr[1]);
            Assert.AreEqual(2, arr[2]);
            Assert.AreEqual(3, arr[3]);
            Assert.AreEqual(4, arr[4]);
        }

        [Test]
        public void Test2()
        {
            int[] arr = new int[0];
            int result = new Q26().RemoveDuplicates(arr);

            Assert.AreEqual(0, result);
        }
    }
}