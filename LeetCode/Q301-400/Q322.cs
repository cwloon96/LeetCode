using System;

namespace LeetCode.Q301_400
{
    public class Q322
    {
        public int CoinChange(int[] coins, int amount)
        {
            if (amount == 0) return 0;

            // index = amount, value = min coin needed to reach the amount (for all coin looped, not only current coin)
            int[] dp = new int[amount + 1];
                
            Array.Fill(dp, int.MaxValue);
            // if the amount is 0, value always 0
            dp[0] = 0;

            /* Eg: coins = [1, 2, 5], amount = 11
             * 1st loop: [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11]
             * 2nd loop: [0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6]
             * 3rd loop: [0, 1, 1, 2, 2, 1, 2, 2, 3, 3, 2, 3]
             * in second loop, dp[3] = 2 came from dp[3 - 2] + 1, the result means 1 coin (value 1) + 1 coin (value 2) = 3, thus 2 coin
            */

            // dp value will keep updating according to the coin value
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