using System.Collections.Generic;

namespace LeetCode.Q1_100
{
    public class Q46
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            BackTracking(nums, new List<int>(), result);
            return result;
        }

        private void BackTracking(int[] nums, IList<int> temp, IList<IList<int>> result)
        {
            if (temp.Count == nums.Length)
            {
                result.Add(new List<int>(temp));
            }
            else
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (!temp.Contains(nums[i]))
                    {
                        temp.Add(nums[i]);
                        BackTracking(nums, temp, result);
                        temp.RemoveAt(temp.Count - 1);
                    }
                }
            }
        }
    }
}