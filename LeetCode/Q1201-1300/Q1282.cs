using System.Collections.Generic;

namespace LeetCode.Q1201_1300
{
    public  class Q1282
    {
        public IList<IList<int>> GroupThePeople(int[] groupSizes)
        {
            List<IList<int>> result = new List<IList<int>>();
            Dictionary<int, List<int>> groups = new Dictionary<int, List<int>>();

            for (int i = 0; i < groupSizes.Length; i++)
            {
                int current = groupSizes[i];
                if (groups.ContainsKey(current))
                    groups[current].Add(i);
                else
                    groups[current] = new List<int> { i };

                if (groups[current].Count == current)
                {
                    result.Add(new List<int>(groups[current]));
                    groups.Remove(current);
                }
            }

            return result;
        }
    }
}