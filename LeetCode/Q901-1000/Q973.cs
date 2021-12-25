using System.Collections.Generic;

namespace LeetCode.Q901_1000
{
    public class Q973
    {
        public int[][] KClosest(int[][] points, int k)
        {
            int len = points.Length, l = 0, r = len - 1;
            while (l <= r)
            {
                int mid = helper(points, l, r);
                if (mid == k) break;
                if (mid < k)
                {
                    l = mid + 1;
                }
                else
                {
                    r = mid - 1;
                }
            }

            var result = new List<int[]>();

            for (int i = 0; result.Count != k; i++)
                result.Add(points[i]);

            return result.ToArray();
        }

        private int helper(int[][] A, int l, int r)
        {
            int[] pivot = A[l];
            while (l < r)
            {
                while (l < r && compare(A[r], pivot) >= 0) r--;
                A[l] = A[r];
                while (l < r && compare(A[l], pivot) <= 0) l++;
                A[r] = A[l];
            }
            A[l] = pivot;
            return l;
        }

        private int compare(int[] p1, int[] p2)
        {
            return p1[0] * p1[0] + p1[1] * p1[1] - p2[0] * p2[0] - p2[1] * p2[1];
        }
    }
}