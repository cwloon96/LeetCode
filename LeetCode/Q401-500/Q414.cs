using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Q401_500
{
    public class Q414
    {
        public int ThirdMax(int[] nums)
        {
            SortedSet<int> sortedSet = new SortedSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                sortedSet.Add(nums[i]);
                if (sortedSet.Count() > 3)
                    sortedSet.Remove(sortedSet.Min);
            }

            return sortedSet.Count() == 3 ? sortedSet.Min : sortedSet.Max;
        }
    }
}