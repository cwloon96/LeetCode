using System;

namespace LeetCode.Q101_200
{
    public class Q121
    {
        public int MaxProfit(int[] prices)
        {
            int max = 0;
            int current = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                current = Math.Max(0, current += prices[i] - prices[i - 1]);
                max = Math.Max(current, max);
            }

            return max;
        }
    }
}