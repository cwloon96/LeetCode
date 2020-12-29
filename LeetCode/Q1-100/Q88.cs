﻿namespace LeetCode.Q1_100
{
    public class Q88
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            for (int i = m + n - 1, j = m - 1, k = n - 1; i >= 0; i--)
            {
                if (j >= 0 && (k < 0 || nums1[j] > nums2[k]))
                    nums1[i] = nums1[j--];
                else
                    nums1[i] = nums2[k--];
            }
        }
    }
}