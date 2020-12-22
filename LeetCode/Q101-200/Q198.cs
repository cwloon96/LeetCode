using System;

namespace LeetCode.Q101_200
{
    public class Q198
    {
        public int Rob(int[] nums)
        {
            int prevTwo = 0;
            int prevOne = 0;
            int max = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                max = Math.Max(prevTwo + nums[i], prevOne);
                prevTwo = prevOne;
                prevOne = max;
            }

            return max;
        }
    }
}