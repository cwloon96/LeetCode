namespace LeetCode.Q101_200
{
    public class Q122
    {
        public int MaxProfit(int[] prices)
        {
            int result = 0;

            for (int i = 0; i < prices.Length - 1; i++)
                if (prices[i] < prices[i + 1])
                    result += prices[i + 1] - prices[i];

            return result;
        }
    }
}