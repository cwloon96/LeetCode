using System;

namespace LeetCode.Q1001_1100
{
    public class Q1029
    {
        public int TwoCitySchedCost(int[][] costs)
        {
            Array.Sort(costs, (a, b) => {
                if (a[0] - a[1] < b[0] - b[1])
                    return -1;
                return 1;
            });

            int result = 0;
            int half = costs.Length / 2;

            for (int i = 0; i < half; i++)
                result += costs[i][0] + costs[i + half][1];

            return result;
        }
    }
}