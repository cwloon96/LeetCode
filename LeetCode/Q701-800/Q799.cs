﻿using System;

namespace LeetCode.Q701_800
{
    public class Q799
    {
        public double ChampagneTower(int poured, int query_row, int query_glass)
        {
            var dp = new double[query_row + 1][];
            for (int i = 0; i < dp.Length; i++)
                dp[i] = new double[i + 1];

            dp[0][0] = poured;

            for (int i = 0; i < query_row; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (dp[i][j] > 1)
                    {
                        dp[i + 1][j] += (dp[i][j] - 1) / 2;
                        dp[i + 1][j + 1] += (dp[i][j] - 1) / 2;
                    }
                }
            }

            return Math.Min(dp[query_row][query_glass], 1);
        }
    }
}