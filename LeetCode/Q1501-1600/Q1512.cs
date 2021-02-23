namespace LeetCode.Q1501_1600
{
    public class Q1512
    {
        public int NumIdenticalPairs(int[] nums)
        {
            int result = 0;
            int[] arr = new int[101];

            // we only need to find how many time the num appear before the current num
            /* Eg: [1, 2, 1]
             * i = 0, result = 0, arr[1] = 1
             * i = 1, result = 0, arr[2] = 1
             * i = 2, result = 1, arr[1] = 2
            */
            for (int i = 0; i < nums.Length; i++)
                result += arr[nums[i]]++;

            return result;
        }
    }
}