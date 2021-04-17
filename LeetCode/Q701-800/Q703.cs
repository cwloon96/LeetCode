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

            /* Looking for k largest value -> only need to store k size value and the smallest value will be the ans
             * EG: k = 3, nums = [1, 2, 3, 4]
             * when adding 3, dict will sorted as 1 -> 2 -> 3, thus k(3) largest = 1
             * when adding 4, dict will became 1 -> 2 -> 3 -> 4, it exceed k size so we remove the first value and k largest = 2
             */
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