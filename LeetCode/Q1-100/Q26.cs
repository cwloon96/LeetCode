namespace LeetCode.Q1_100
{
    public class Q26
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
                return 0;

            int left = 0, right = 1;

            while (right < nums.Length)
            {
                if (nums[left] != nums[right])
                {
                    left++;
                    nums[left] = nums[right];
                }
                right++;
            }

            return left + 1;
        }
    }
}