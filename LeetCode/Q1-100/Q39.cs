using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Q1_100
{
    public class Q39
    {
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            IList<IList<int>> result = new List<IList<int>>();
            BackTrack(candidates, target, result, new List<int>(), 0);
            return result;
        }

        private void BackTrack(int[] candidates, int target, IList<IList<int>> result, List<int> temp, int start)
        {
            int sum = temp.Sum();

            if (sum == target)
                result.Add(new List<int>(temp));
            else if (sum > target)
                return;
            else
            {
                for (int i = start; i < candidates.Length; i++)
                {
                    temp.Add(candidates[i]);
                    BackTrack(candidates, target, result, temp, i);
                    temp.RemoveAt(temp.Count - 1);
                }
            }
        }
    }
}