namespace LeetCode.Q901_1000
{
    public class Q905
    {
        public int[] SortArrayByParity(int[] A)
        {
            int left = 0;
            int right = 1;

            while (right < A.Length)
            {
                if (A[left] % 2 != 0 && A[right] % 2 == 0)
                {
                    int temp = A[right];
                    A[right] = A[left];
                    A[left] = temp;
                }

                if (A[left] % 2 == 0)
                    left++;

                right++;
            }

            return A;
        }
    }
}