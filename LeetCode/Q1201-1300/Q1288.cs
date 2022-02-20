using System;

namespace LeetCode.Q1201_1300
{
    public class Q1288
    {
        public int RemoveCoveredIntervals(int[][] intervals)
        {
            // Sort left asc, right desc
            // Eg:  [[1,4],[3,6],[2,8],[2,4]] ->  [[1,4],[2,8],[2,4],[3,6]]
            Array.Sort(intervals, (x, y) => {
                if (x[0] == y[0])
                    return y[1].CompareTo(x[1]);

                return x[0].CompareTo(y[0]);
            });

            int count = 0, maxRight = 0;

            // each time we found a larger right means new intervals
            foreach (var interval in intervals)
            {
                if (interval[1] > maxRight)
                {
                    count++;
                    maxRight = interval[1];
                }
            }

            return count;
        }
    }
}