using LeetCode.Q1_100;
using NUnit.Framework;

namespace LeetCode.Test.Q1_100
{
    public class Q27Test
    {
        [Test]
        public void Test()
        {
            int[] arr = new[] { 3, 2, 2, 3 };
            int result = new Q27().RemoveElement(arr, 3);

            Assert.AreEqual(2, result);
            Assert.AreEqual(2, arr[0]);
            Assert.AreEqual(2, arr[1]);
        }

        [Test]
        public void Test2()
        {
            int[] arr = new[] { 1 };
            int result = new Q27().RemoveElement(arr, 1);

            Assert.AreEqual(0, result);
        }
    }
}