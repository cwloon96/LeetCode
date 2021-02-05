namespace LeetCode.Q1_100
{
    public class Q62
    {
        public int UniquePaths(int m, int n)
        {
            int[] dp = new int[n];

            for (int i = 0; i < n; i++)
                dp[i] = 1;

            for (int row = 1; row < m; row++)
                for (int col = 1; col < n; col++)
                    dp[col] += dp[col - 1];

            return dp[n - 1];
        }
    }
}