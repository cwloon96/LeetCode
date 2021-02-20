namespace LeetCode.Q1401_1500
{
    public class Q1470
    {
        public int[] Shuffle(int[] nums, int n)
        {
            int[] result = new int[nums.Length];

            // each time will add two element to result array, thus i += 2
            // j is to loop the original array, thus j++
            for (int i = 0, j = 0; j < n; i += 2, j++)
            {
                result[i] = nums[j];
                result[i + 1] = nums[j + n];
            }

            return result;
        }
    }
}