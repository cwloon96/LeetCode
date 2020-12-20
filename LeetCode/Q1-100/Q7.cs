namespace LeetCode.Q1_100
{
    public class Q7
    {
        public int Reverse(int x)
        {
            int result = 0;

            while (x != 0)
            {
                // result * 10 to add one more digit
                // x % 10 to get last digit in x
                int newResult = (result * 10) + (x % 10);

                // newResult / 10 equals newResult after removing last digit
                // check if newResult is still similar with previos result after removing last digit
                if (newResult / 10 != result)
                    return 0;

                x /= 10;
                result = newResult;
            }

            return result;
        }
    }
}