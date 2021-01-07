using System.Collections.Generic;

namespace LeetCode.Q401_500
{
    public class Q448
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                while (nums[nums[i] - 1] != nums[i])
                {
                    // temp cannot be nums[i], else when we update nums[i] in second row, the third row will be affected
                    int temp = nums[nums[i] - 1];
                    nums[nums[i] - 1] = nums[i];
                    nums[i] = temp;
                }
            }

            List<int> result = new List<int>();
            for (int i = 0; i < nums.Length; i++)
                if (nums[i] != i + 1)
                    result.Add(i + 1);

            return result;
        }
    }
}