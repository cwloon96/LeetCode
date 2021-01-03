namespace LeetCode.Q201_300
{
    public class Q283
    {
        public void MoveZeroes(int[] nums)
        {
            for (int left = 0, right = 1; right < nums.Length; right++)
            {
                if (nums[left] == 0 && nums[right] != 0)
                {
                    nums[left] = nums[right];
                    nums[right] = 0;
                    left++;
                }

                if (nums[left] != 0)
                    left++;
            }
        }
    }
}