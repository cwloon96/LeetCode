using System;

namespace LeetCode.Q1_100
{
    public class Q53
    {
        // dp
        public int MaxSubArrayDP(int[] nums)
        {
            int result = nums[0];
            int current = result;

            for (int i = 1; i < nums.Length; i++)
            {
                current = Math.Max(nums[i], nums[i] + current);
                result = Math.Max(result, current);
            }

            return result;
        }

        // divide and conquer
        public int MaxSubArrayDAC(int[] nums)
        {
            return MaxSubArray(nums, 0, nums.Length - 1);
        }

        private int MaxSubArray(int[] nums, int left, int right)
        {
            if (left > right)
                return int.MinValue;

            int mid = (left + right) / 2;
            int maxLeft = MaxSubArray(nums, left, mid - 1);
            int maxRight = MaxSubArray(nums, mid + 1, right);

            int currentLeftMax = 0;
            for (int i = mid - 1, sum = 0; i >= left; i--)
            {
                sum += nums[i];
                currentLeftMax = Math.Max(sum, currentLeftMax);
            }

            int currentRightMax = 0;
            for (int i = mid + 1, sum = 0; i <= right; i++)
            {
                sum += nums[i];
                currentRightMax = Math.Max(sum, currentRightMax);
            }

            return Math.Max(Math.Max(maxLeft, maxRight), currentLeftMax + currentRightMax + nums[mid]);
        }
    }
}