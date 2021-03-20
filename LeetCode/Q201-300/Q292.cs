namespace LeetCode.Q201_300
{
    public class Q292
    {
        public bool CanWinNim(int n)
        {
            /* when number is 4K, first person sure lose
             * Eg: 4
             * No matter first person pick 1 ~ 3, the second person can pick the remaining and win
             * Eg: 8
             * No matter first person pick 1 ~ 3, the second person can pick until the remaining = 4
             */
            return n % 4 != 0;
        }
    }
}