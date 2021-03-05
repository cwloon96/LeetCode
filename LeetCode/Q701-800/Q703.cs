using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Q701_800
{
    public class KthLargest
    {
        private int target;
        private int size;
        private SortedDictionary<int, int> dict = new SortedDictionary<int, int>();

        public KthLargest(int k, int[] nums)
        {
            target = k;
            foreach (var num in nums)
                Add(num);
        }

        public int Add(int val)
        {
            if (dict.ContainsKey(val))
                dict[val]++;
            else
                dict.Add(val, 1);
            size++;

            if (size > target)
            {
                var first = dict.First();
                if (first.Value == 1)
                    dict.Remove(first.Key);
                else
                    dict[first.Key]--;
                size--;
            }

            return dict.First().Key;
        }
    }
}