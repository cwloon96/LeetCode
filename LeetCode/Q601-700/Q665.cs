namespace LeetCode.Q601_700
{
    public class Q665
    {
        public bool CheckPossibility(int[] nums)
        {
            bool found = false;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < nums[i - 1])
                {
                    if (found)
                        return false;

                    // eg: [1,2,3,1,2]
                    if (i >= 2 && nums[i] < nums[i - 2] &&
                       i + 1 < nums.Length && nums[i - 1] > nums[i + 1])
                        return false;

                    found = true;
                }
            }

            return true;
        }
    }
}