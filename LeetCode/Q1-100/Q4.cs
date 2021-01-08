using System;

namespace LeetCode.Q1_100
{
    public class Q4
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            if (nums1.Length > nums2.Length)
                return FindMedianSortedArrays(nums2, nums1);

            return FindMedian(nums1, nums2, 0, nums1.Length);
        }

        private double FindMedian(int[] nums1, int[] nums2, int start, int end)
        {
            int x = nums1.Length;
            int y = nums2.Length;

            // partition = how many element in left side
            // partitionX + partitionY = (x + y + 1) / 2;
            // + 1 for odd num case
            int partitionX = (start + end) / 2;
            int partitionY = ((x + y + 1) / 2) - partitionX;

            int leftX = partitionX > 0 ? nums1[partitionX - 1] : int.MinValue;
            int rightX = partitionX >= x ? int.MaxValue : nums1[partitionX];

            int leftY = partitionY > 0 ? nums2[partitionY - 1] : int.MinValue;
            int rightY = partitionY >= y ? int.MaxValue : nums2[partitionY];

            if (leftX > rightY)
                return FindMedian(nums1, nums2, start, --partitionX);
            if (leftY > rightX)
                return FindMedian(nums1, nums2, ++partitionX, end);

            if ((nums1.Length + nums2.Length) % 2 == 0)
                return (double)(Math.Max(leftX, leftY) + Math.Min(rightX, rightY)) / 2;
            else
                return Math.Max(leftX, leftY);
        }
    }
}