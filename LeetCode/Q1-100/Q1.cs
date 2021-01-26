using System.Collections.Generic;

namespace LeetCode.Q1_100
{
    public class Q1
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int[] result = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                int current = nums[i];
                int remain = target - current;

                if (dict.ContainsKey(remain))
                {
                    result[0] = dict[remain];
                    result[1] = i;
                    break;
                }

                dict.Add(current, i);

            }

            return result;
        }
    }
}