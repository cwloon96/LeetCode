namespace LeetCode.Q301_400
{
    public class Q392
    {
        public bool IsSubsequence(string s, string t)
        {
            int i = 0;
            for (int j = 0; j < t.Length && i < s.Length; j++)
                if (t[j] == s[i]) i++;

            return i == s.Length;
        }
    }
}