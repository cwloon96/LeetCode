namespace LeetCode.Q901_1000
{
    public class Q977
    {
        public int[] SortedSquares(int[] A)
        {
            int begin = 0;
            int end = A.Length - 1;
            int[] ans = new int[A.Length];
            int ansIndex = A.Length - 1;

            while (begin <= end)
            {
                int pow1 = A[begin] * A[begin];
                int pow2 = A[end] * A[end];

                if (pow1 < pow2)
                {
                    ans[ansIndex--] = pow2;
                    end--;
                }
                else
                {
                    ans[ansIndex--] = pow1;
                    begin++;
                }
            }

            return ans;
        }
    }
}