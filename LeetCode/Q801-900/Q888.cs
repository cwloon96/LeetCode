using System.Collections.Generic;

namespace LeetCode.Q801_900
{
    public class Q888
    {
        public int[] FairCandySwap(int[] A, int[] B)
        {
            int alice = 0;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (int i in A)
            {
                alice += i;
                if (dict.ContainsKey(i))
                    dict[i]++;
                else
                    dict[i] = 1;
            }

            int bob = 0;
            foreach (int i in B)
                bob += i;

            int avg = (alice + bob) / 2;
            int[] result = new int[2];

            foreach (int i in B)
            {
                // how much still needed from A after dudecting i
                int left = avg - (bob - i);
                if (dict.ContainsKey(left) && (alice - left + i == avg))
                {
                    result[0] = left;
                    result[1] = i;
                    break;
                }
            }

            return result;
        }
    }
}