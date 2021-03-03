using System;

namespace LeetCode.Q401_500
{
    public class Q455
    {
        public int FindContentChildren(int[] g, int[] s)
        {
            Array.Sort(g);
            Array.Sort(s);

            int result = 0;
            for (int i = 0; i < s.Length && result < g.Length; i++)
                if (g[result] <= s[i])
                    result++;

            return result;
        }
    }
}