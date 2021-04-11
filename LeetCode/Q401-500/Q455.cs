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

        public int FindContentChildrenTwoPointer(int[] g, int[] s)
        {
            Array.Sort(g);
            Array.Sort(s);

            int i = 0, j = 0;

            while (i < g.Length && j < s.Length)
            {
                if (g[i] <= s[j])
                {
                    i++;
                    j++;
                }
                else
                    j++;
            }

            return i;
        }
    }
}