using System;

namespace LeetCode.Q201_300
{
    public class Q300
    {
        public int LengthOfLIS(int[] nums)
        {
            int[] history = new int[nums.Length];
            int result = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                for (int j = 0; j < i; j++)
                    if (nums[j] < nums[i])
                        history[i] = Math.Max(history[i], history[j] + 1);

                result = Math.Max(result, history[i]);
            }

            return result + 1;
        }
    }
}