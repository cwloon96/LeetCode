namespace LeetCode.Q1_100
{
    public class Q27
    {
        public int RemoveElement(int[] nums, int val)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                if (nums[left] == val)
                {
                    nums[left] = nums[right];
                    right--;
                }
                else
                    left++;
            }

            return left;
        }
    }
}