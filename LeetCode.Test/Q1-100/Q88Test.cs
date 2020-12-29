using LeetCode.Q1_100;
using NUnit.Framework;

namespace LeetCode.Test.Q1_100
{
    public class Q88Test
    {
        [Test]
        public void Test()
        {
            int[] nums1 = new[] { 1, 2, 3, 0, 0, 0 };
            int[] nums2 = new[] { 2, 5, 6 };

            new Q88().Merge(nums1, 3, nums2, 3);

            Assert.AreEqual(1, nums1[0]);
            Assert.AreEqual(2, nums1[1]);
            Assert.AreEqual(2, nums1[2]);
            Assert.AreEqual(3, nums1[3]);
            Assert.AreEqual(5, nums1[4]);
            Assert.AreEqual(6, nums1[5]);
        }
    }
}