using System;

namespace LeetCode.Q101_200
{
    public class Q132
    {
        public int MinCut(string s)
        {
            int size = s.Length;
            int[] cut = new int[size + 1]; // number of cuts of first x characters

            // assign max cut to every first x characters
            for (int i = 0; i <= size; i++)
                cut[i] = i - 1;
            for (int mid = 0; mid < size; mid++)
            {
                // odd palindrome
                for (int length = 0; mid - length >= 0 && mid + length < size && s[mid - length] == s[mid + length]; length++)
                    cut[mid + length + 1] = Math.Min(cut[mid + length + 1], 1 + cut[mid - length]);
                
                // even palindrome
                for (int length = 1; mid - length + 1 >= 0 && mid + length + 1 < size && s[mid - length + 1] == s[mid + length]; length++)
                    cut[mid + length + 1] = Math.Min(cut[mid + length + 1], 1 + cut[mid - length + 1]);
            }

            return cut[size];
        }
    }
}