using System;

namespace LeetCode.Q1201_1300
{
    public class Q1299
    {
        public int[] ReplaceElements(int[] arr)
        {
            int max = -1;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                int temp = arr[i];
                arr[i] = max;
                max = Math.Max(temp, max);
            }

            return arr;
        }
    }
}