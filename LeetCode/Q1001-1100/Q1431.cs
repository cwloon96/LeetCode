using System;
using System.Collections.Generic;

namespace LeetCode.Q1001_1100
{
    public class Q1431
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            int maxCandies = candies[0];
            for (int i = 1; i < candies.Length; i++)
                maxCandies = Math.Max(candies[i], maxCandies);

            List<bool> result = new List<bool>();

            for (int i = 0; i < candies.Length; i++)
                result.Add(candies[i] + extraCandies >= maxCandies);

            return result;
        }
    }
}