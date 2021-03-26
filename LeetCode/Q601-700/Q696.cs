using System;

namespace LeetCode.Q601_700
{
    public class Q696
    {
        public int CountBinarySubstrings(string s)
        {
            int previous = 0, current = 1, result = 0;

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == s[i - 1])
                    current++;
                else
                {
                    // if previous = 3 and current = 2 -> 00011 = 2 valid substring [01, 0011]
                    result += Math.Min(previous, current);
                    previous = current;
                    current = 1;
                }
            }

            return result + Math.Min(previous, current);
        }
    }
}