using System;
using System.Collections.Generic;

namespace LeetCode.Q1_100
{
    public class Q47
    {
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            Array.Sort(nums);
            var result = new List<IList<int>>();
            BackTrack(nums, result, new List<int>(), new bool[nums.Length]);
            return result;
        }

        private void BackTrack(int[] nums, List<IList<int>> result, List<int> temp, bool[] used)
        {
            if (temp.Count == nums.Length)
            {
                result.Add(new List<int>(temp));
                return;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if ((used[i]) || (i > 0 && nums[i] == nums[i - 1] && used[i - 1]))
                    continue;

                used[i] = true;
                temp.Add(nums[i]);

                BackTrack(nums, result, temp, used);

                temp.RemoveAt(temp.Count - 1);
                used[i] = false;
            }
        }
    }
}
