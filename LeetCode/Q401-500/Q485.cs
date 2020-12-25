namespace LeetCode.Q401_500
{
    public class Q485
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            if (nums.Length == 0) return 0;

            int count = 0;
            int max = 0;
            foreach (int num in nums)
            {
                if (num == 1)
                {
                    count++;
                    max = max > count ? max : count;
                }
                else count = 0;
            }
            return max;
        }
    }
}