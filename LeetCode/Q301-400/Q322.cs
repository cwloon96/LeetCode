using System;

namespace LeetCode.Q301_400
{
    public class Q322
    {
        public int CoinChange(int[] coins, int amount)
        {
            if (amount == 0) return 0;

            // index = amount, value = min coin needed to reach the amount
            int[] dp = new int[amount + 1];
                
            Array.Fill(dp, int.MaxValue);
            // if the amount is 0, value always 0
            dp[0] = 0;

            // value will keep updating according to the coin value
            foreach (int coin in coins)
            {
                for (int i = coin; i <= amount; i++)
                {
                    // every first time enter to this loop, i - coin must be 0, so the first value can always enter to this if statement
                    if (dp[i - coin] != int.MaxValue)
                    {
                        // (i - coin) = the minimum coin needed to reach the nearest value which is the current amount - current coin value
                        dp[i] = Math.Min(dp[i], dp[i - coin] + 1);
                    }
                }
            }

            return dp[amount] == int.MaxValue ? -1 : dp[amount];
        }
    }
}