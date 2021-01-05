namespace LeetCode.Q1001_1100
{
    public class Q1051
    {
        public int HeightChecker(int[] heights)
        {
            int[] arr = new int[101];

            for (int i = 0; i < heights.Length; i++)
                arr[heights[i]]++;

            int currentHeight = 0;
            int result = 0;

            for (int i = 0; i < heights.Length; i++)
            {
                while (arr[currentHeight] == 0)
                    currentHeight++;

                if (heights[i] != currentHeight)
                    result++;

                arr[currentHeight]--;
            }

            return result;
        }
    }
}