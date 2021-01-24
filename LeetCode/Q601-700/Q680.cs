namespace LeetCode.Q601_700
{
    public class Q680
    {
        public bool ValidPalindrome(string s)
        {
            int left = 0;
            int right = s.Length - 1;

            while (left < right && left < s.Length && right >= 0)
            {
                if (s[left] != s[right])
                    return IsPalindrome(s.Substring(left, right - left)) ||
                        IsPalindrome(s.Substring(left + 1, right - left));

                left++;
                right--;
            }

            return true;
        }

        private bool IsPalindrome(string s)
        {
            int left = 0;
            int right = s.Length - 1;

            while (left < right && left < s.Length && right >= 0 && s[left] == s[right])
            {
                left++;
                right--;
            }

            return left >= right;
        }
    }
}