using System.Collections.Generic;

namespace LeetCode.Q101_200
{
    public class Q139
    {
        public bool WordBreak(string s, IList<string> wordDict)
        {
            bool[] dp = new bool[s.Length + 1];
            dp[0] = true;

            for (int right = 1; right <= s.Length; right++)
            {
                for (int left = right - 1; left >= 0; left--)
                {
                    if (dp[left] && wordDict.Contains(s.Substring(left, right - left)))
                    {
                        dp[right] = true;
                        break;
                    }
                }
            }

            return dp[s.Length];
        }
    }
}