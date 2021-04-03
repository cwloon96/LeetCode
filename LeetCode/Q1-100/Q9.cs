namespace LeetCode.Q1_100
{
    public class Q9
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0 || (x != 0 && x % 10 == 0))
                return false;

            int sum = 0;
            while (x > sum)
            {
                sum = sum * 10 + x % 10;
                x /= 10;
            }

            /* sum == x happens when x has even digit
             * Eg: 1221
             * x = 12, sum = 12
             * 
             * sum / 10 == x happens when x has odd digit
             * Eg: 121
             * x = 1, sum = 12
            */
            return (sum == x) || (sum / 10 == x);
        }
    }
}