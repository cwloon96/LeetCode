using System;
using System.Collections.Generic;

namespace LeetCode.Q1_100
{
    public class Q90
    {
        public IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            Array.Sort(nums);
            IList<IList<int>> result = new List<IList<int>>();
            BackTrack(nums, result, new List<int>(), 0);
            return result;
        }

        private void BackTrack(int[] nums, IList<IList<int>> result, IList<int> temp, int start)
        {
            result.Add(new List<int>(temp));

            for (int i = start; i < nums.Length; i++)
            {
                if (i > start && nums[i - 1] == nums[i])
                    continue;

                temp.Add(nums[i]);
                BackTrack(nums, result, temp, i + 1);
                temp.RemoveAt(temp.Count - 1);
            }
        }
    }
}