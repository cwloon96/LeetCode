using LeetCode.Q201_300;
using NUnit.Framework;

namespace LeetCode.Test.Q201_300
{
    class Q283Test
    {
        [Test]
        public void Test()
        {
            int[] arr = new[] { 0, 1, 0, 3, 12 };
            new Q283().MoveZeroes(arr);

            Assert.AreEqual(1, arr[0]);
            Assert.AreEqual(3, arr[1]);
            Assert.AreEqual(12, arr[2]);
            Assert.AreEqual(0, arr[3]);
            Assert.AreEqual(0, arr[4]);
        }
    }
}