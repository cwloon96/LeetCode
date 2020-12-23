using System;

namespace LeetCode.Q201_300
{
    public class Q213
    {
        public int Rob(int[] nums)
        {
            if (nums.Length == 0) return 0;
            if (nums.Length == 1) return nums[0];

            return Math.Max(Rob(nums, 0, nums.Length - 1), Rob(nums, 1, nums.Length));
        }

        private int Rob(int[] nums, int left, int right)
        {
            int prevOne = 0;
            int prevTwo = 0;
            int max = 0;

            for (int i = left; i < right; i++)
            {
                max = Math.Max(prevTwo + nums[i], prevOne);
                prevTwo = prevOne;
                prevOne = max;
            }

            return max;
        }
    }
}