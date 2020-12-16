using System;
using System.Collections.Generic;

namespace LeetCode.Q1_100
{
    public class Q3
    {
        public int LengthOfLongestSubstring(string s)
        {
            int result = 0;
            int left = 0;
            int right = 0;
            HashSet<char> characters = new HashSet<char>();

            while (right < s.Length)
            {
                if (characters.Contains(s[right]))
                    characters.Remove(s[left++]);
                else
                    characters.Add(s[right++]);

                result = Math.Max(result, characters.Count);
            }

            return result;
        }
    }
}