namespace LeetCode.Q201_300
{
    public class Q238
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int[] result = new int[nums.Length];

            /* Eg: [2, 3, 4, 5]
             * first loop, result = 
             * [1, 
             * 2, 
             * 2 * 3, 
             * 2 * 3 * 4] -> [1, 2, 6, 24]
             * second loop, result = 
             * [1 * 5 * 4 * 3 , 
             * 2 * 5 * 4, 
             * 6 * 5,
             * 24 * 1] -> [60, 40, 30, 24]
            */

            // temp = multiplied value of all nums before the current num
            for (int i = 0, temp = 1; i < nums.Length; i++)
            {
                result[i] = temp;
                temp *= nums[i];
            }

            for (int i = nums.Length - 1, temp = 1; i >= 0; i--)
            {
                result[i] *= temp;
                temp *= nums[i];
            }

            return result;
        }
    }
}