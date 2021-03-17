using System;
using System.Collections.Generic;

namespace LeetCode.Q601_700
{
    public class Q697
    {
        public int FindShortestSubArray(int[] nums)
        {
            Dictionary<int, int> count = new Dictionary<int, int>(); // occurance of each element
            Dictionary<int, int> first = new Dictionary<int, int>(); // index of first element of each numbers
            int result = 0, max = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (count.ContainsKey(nums[i]))
                    count[nums[i]]++;
                else
                {
                    count[nums[i]] = 1;
                    first[nums[i]] = i;
                }

                if (count[nums[i]] > max)
                {
                    max = count[nums[i]];
                    // last - first + 1 = array size
                    result = i - first[nums[i]] + 1;
                }
                else if (count[nums[i]] == max)
                    result = Math.Min(result, i - first[nums[i]] + 1);
            }

            return result;
        }
    }
}