namespace LeetCode.Q1_100
{
    public class Q70
    {
        public int ClimbStairs(int n)
        {
            if (n <= 2)
                return n;

            int oneStepBefore = 2;
            int twoStepBefore = 1;
            int result = 0;

            for (int i = 2; i < n; i++)
            {
                result = oneStepBefore + twoStepBefore;
                twoStepBefore = oneStepBefore;
                oneStepBefore = result;
            }

            return result;
        }
    }
}