using System;
using System.Text;

namespace LeetCode.Q1701_1800
{
    public class Q1768
    {
        public string MergeAlternately(string word1, string word2)
        {
            StringBuilder sb = new StringBuilder();
            int max = Math.Max(word1.Length, word2.Length);

            for (int i = 0; i < max; i++)
            {
                if (i < word1.Length)
                    sb.Append(word1[i]);

                if (i < word2.Length)
                    sb.Append(word2[i]);
            }

            return sb.ToString();
        }
    }
}