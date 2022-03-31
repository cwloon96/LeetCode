using System;
using System.Collections.Generic;

namespace LeetCode.Q1601_1700
{
    public class Q1675
    {
		public int MinimumDeviation(int[] nums)
		{
			SortedSet<int> set = new SortedSet<int>();

			foreach (var num in nums)
			{
				if (num % 2 == 0)
					set.Add(num);
				else
					set.Add(num * 2);
			}

			int result = set.Max - set.Min;
			while (set.Max % 2 == 0)
			{
				int last = set.Max;
				set.Remove(last);
				set.Add(last / 2);
				result = Math.Min(result, set.Max - set.Min);
			}

			return result;
		}
	}
}
