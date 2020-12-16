namespace LeetCode.Q1301_1400
{
    public class Q1395
    {
        public int NumTeams(int[] rating)
        {
            int result = 0;

            for (int i = 1; i < rating.Length - 1; i++)
            {
                int greatBefore = 0;
                int greatAfter = 0;
                int lessBefore = 0;
                int lessAfter = 0;

                for (int j = i - 1; j >= 0; j--)
                {
                    if (rating[j] < rating[i])
                        lessBefore++;
                    else if (rating[j] > rating[i])
                        greatBefore++;
                }

                for (int j = i + 1; j < rating.Length; j++)
                {
                    if (rating[j] < rating[i])
                        lessAfter++;
                    else if (rating[j] > rating[i])
                        greatAfter++;
                }

                result += lessBefore * greatAfter;
                result += greatBefore * lessAfter;
            }

            return result;
        }
    }
}