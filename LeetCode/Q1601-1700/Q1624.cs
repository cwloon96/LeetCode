using System;
using System.Collections.Generic;

namespace LeetCode.Q1601_1700
{
    public class Q1624
    {
        public int MaxLengthBetweenEqualCharacters(string s)
        {
            int result = -1;
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i]))
                {
                    int length = i - dict[s[i]] - 1;
                    result = Math.Max(result, length);
                }
                else
                {
                    dict[s[i]] = i;
                }
            }

            return result;
        }
    }
}