namespace LeetCode.Q601_700
{
    public class Q647
    {
        public int CountSubstrings(string s)
        {
            int result = 0;

            for (int i = 0; i < s.Length; i++)
            {
                result += CountPalindrome(s, i, i);
                result += CountPalindrome(s, i, i + 1);
            }

            return result;
        }

        private int CountPalindrome(string s, int left, int right)
        {
            int result = 0;

            while (left >= 0 && right < s.Length && s[left--] == s[right++])
                result++;

            return result;
        }
    }
}