using System;
using System.Text;

namespace LeetCode.Q101_200
{
    public class Q179
    {
        public string LargestNumber(int[] nums)
        {
            var arr = new string[nums.Length];

            for (int i = 0; i < nums.Length; i++)
                arr[i] = nums[i].ToString();

            Array.Sort(arr, (s1, s2) => {
                var case1 = s1 + s2;
                var case2 = s2 + s1;

                return case2.CompareTo(case1);
            });

            if (arr[0][0] == '0')
                return "0";

            var sb = new StringBuilder();
            for (int i = 0; i < arr.Length; i++)
                sb.Append(arr[i]);

            return sb.ToString();
        }
    }
}