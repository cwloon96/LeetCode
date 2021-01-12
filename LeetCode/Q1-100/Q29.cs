using System;

namespace LeetCode.Q1_100
{
    public class Q29
    {
        public int Divide(int dividend, int divisor)
        {
            if (dividend == int.MinValue && divisor == -1)
                return int.MaxValue;
            if (dividend == int.MaxValue && divisor == -1)
                return int.MinValue;

            int result = Calculate(Math.Abs((long)dividend), Math.Abs((long)divisor));

            return (dividend >= 0 == divisor >= 0) ? result : -result;
        }

        private int Calculate(long dividend, long divisor)
        {
            if (divisor > dividend)
                return 0;

            int count = 1;
            long accumulate = divisor;

            while (accumulate << 1 <= dividend)
            {
                count <<= 1;
                accumulate <<= 1;
            }

            return count + Calculate(dividend - accumulate, divisor);
        }
    }
}