using System;

namespace LeetCode.Q1601_1700
{
    public class Q1672
    {
        public int MaximumWealth(int[][] accounts)
        {
            int result = 0;

            for (int i = 0; i < accounts.Length; i++)
            {
                int current = 0;
                for (int j = 0; j < accounts[i].Length; j++)
                    current += accounts[i][j];

                result = Math.Max(result, current);
            }

            return result;
        }
    }
}