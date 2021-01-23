namespace LeetCode.Q1_100
{
    public class Q5
    {
        public string LongestPalindrome(string s)
        {
            string result = "";

            for (int i = 0; i < s.Length; i++)
            {
                string odd = GetPalindrome(i, i, s);
                string even = GetPalindrome(i, i + 1, s);

                string current = odd.Length > even.Length ? odd : even;
                result = current.Length > result.Length ? current : result;
            }

            return result;
        }

        private string GetPalindrome(int left, int right, string s)
        {
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }

            return s.Substring(left + 1, right - 1 - left);
        }
    }
}