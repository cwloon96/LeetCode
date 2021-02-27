using System;

namespace LeetCode.Q1701_1800
{
    public class Q1732
    {
        public int LargestAltitude(int[] gain)
        {
            int max = 0;
            int current = 0;

            for (int i = 0; i < gain.Length; i++)
            {
                current += gain[i];
                max = Math.Max(max, current);
            }

            return max;
        }
    }
}