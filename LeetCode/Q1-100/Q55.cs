using System;

namespace LeetCode.Q1_100
{
    public class Q55
    {
        public bool CanJump(int[] nums)
        {
            int max = 0;

            for (int i = 0; i < nums.Length && max < nums.Length && i <= max; i++)
                max = Math.Max(max, i + nums[i]);

            return max >= nums.Length - 1;
        }
    }
}