﻿using System.Collections.Generic;

namespace LeetCode.Q1001_1100
{
    public class Q1078
    {
        public string[] FindOcurrences(string text, string first, string second)
        {
            string[] words = text.Split(" ");
            List<string> result = new List<string>();

            for (int i = 0; i < words.Length - 2; i++)
            {
                if (words[i] == first && words[i + 1] == second)
                    result.Add(words[i + 2]);
            }

            return result.ToArray();
        }
    }
}