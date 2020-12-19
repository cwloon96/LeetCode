namespace LeetCode.Q201_300
{
    public class Q268
    {
        public int MissingNumber(int[] nums)
        {
            /* XOR EG:
             * a ^ 0 = a;
             * a ^ a = 0;
             * a ^ b ^ b = a;
            */

            int result = nums.Length;

            for(int i = 0; i < nums.Length; i++)
                result = result ^ i ^ nums[i];

            /* EG:
             * Input: [3, 0, 1]
             * result = 3 ^ 0 ^ 3 ^ 1 ^ 0 ^ 2 ^ 1
             * result = 0 ^ 0 ^ 1 ^ 1 ^ 3 ^ 3 ^ 2
             * result = 2
            */

            return result;
        }
    }
}