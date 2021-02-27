namespace LeetCode.Q201_300
{
    public class Q263
    {
        public bool IsUgly(int num)
        {
            if (num < 1) return false;

            foreach (int divisor in new[] { 2, 3, 5 })
                while (num % divisor == 0)
                    num /= divisor;

            return num == 1;
        }
    }
}