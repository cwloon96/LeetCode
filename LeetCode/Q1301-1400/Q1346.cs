using System.Collections.Generic;

namespace LeetCode.Q1301_1400
{
    public class Q1346
    {
        public bool CheckIfExist(int[] arr)
        {
            HashSet<double> hashset = new HashSet<double>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (hashset.Contains(arr[i] * 2) || hashset.Contains((double)arr[i] / 2))
                    return true;

                hashset.Add(arr[i]);
            }

            return false;
        }
    }
}