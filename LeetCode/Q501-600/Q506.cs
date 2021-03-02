using System;
using System.Collections.Generic;

namespace LeetCode.Q501_600
{
    public class Q506
    {
        public string[] FindRelativeRanks(int[] score)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            int length = score.Length;

            // add value -> index into map
            for (int i = 0; i < length; i++)
                map.Add(score[i], i);

            // sort them to get ranking
            Array.Sort(score);
            string[] result = new string[length];

            for (int rankIndex = 0; rankIndex < length; rankIndex++)
            {
                // use rankIndex to trace the current ranking
                // 0 means first rank which is the last element, thus length - 1 - rankIndex to get last element
                int index = map[score[length - 1 - rankIndex]];

                if (rankIndex == 0)
                    result[index] = "Gold Medal";
                else if (rankIndex == 1)
                    result[index] = "Silver Medal";
                else if (rankIndex == 2)
                    result[index] = "Bronze Medal";
                else
                    result[index] = (rankIndex + 1).ToString();
            }

            return result;
        }
    }
}