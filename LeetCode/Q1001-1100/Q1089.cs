namespace LeetCode.Q1001_1100
{
    public class Q1089
    {
        public void DuplicateZeros(int[] arr)
        {
            int zeroCnt = 0;
            foreach (int num in arr)
            {
                if (num == 0)
                    zeroCnt++;
            }

            // left & right keep decreasing to remove the elements which not included in result array
            for (int left = arr.Length - 1, right = arr.Length + zeroCnt - 1; 
                left >= 0 && left < right; 
                left--, right--)
            {
                // right is within array length, which mean the unused element already skipped in left, assign right = left
                if (right < arr.Length)
                    arr[right] = arr[left];

                if (arr[left] == 0)
                {
                    // since assign from right, which mean the duplicated 0 need to appear in front of right, so right--
                    right--;

                    if (right < arr.Length)
                        arr[right] = 0;
                }
            }
        }
    }
}