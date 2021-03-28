namespace LeetCode.Q901_1000
{
    public class Q997
    {
        public int FindJudge(int N, int[][] trust)
        {
            int[] trusted = new int[N + 1];

            for (int i = 0; i < trust.Length; i++)
            {
                trusted[trust[i][0]]--;
                trusted[trust[i][1]]++;
            }

            // Since everyone will trust the judge except himself = N - 1
            for (int i = 1; i < trusted.Length; i++)
                if (trusted[i] == N - 1)
                    return i;

            return -1;
        }
    }
}