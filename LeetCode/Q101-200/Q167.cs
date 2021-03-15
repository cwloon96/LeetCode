using System.Collections.Generic;

namespace LeetCode.Q101_200
{
    public class Q167
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int[] result = new int[2];

            for (int i = 0; i < numbers.Length; i++)
            {
                int remain = target - numbers[i];
                if (dict.ContainsKey(remain))
                {
                    result[0] = dict[remain];
                    result[1] = i + 1;
                    break;
                }

                if (!dict.ContainsKey(numbers[i]))
                    dict.Add(numbers[i], i + 1);
            }

            return result;
        }
    }
}