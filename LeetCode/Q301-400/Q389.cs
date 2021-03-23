namespace LeetCode.Q301_400
{
    public class Q389
    {
        public char FindTheDifference(string s, string t)
        {
            char result = t[t.Length - 1];

            for (int i = 0; i < s.Length; i++)
            {
                result ^= s[i];
                result ^= t[i];
            }

            return result;
        }
    }
}