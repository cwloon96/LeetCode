namespace LeetCode.Q101_200
{
    public class Q125
    {
        public bool IsPalindrome(string s)
        {
            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                if (!IsValid(s[left]) && left < s.Length - 1)
                {
                    left++;
                    continue;
                }

                if (!IsValid(s[right]) && right > 0)
                {
                    right--;
                    continue;
                }

                if (char.ToLower(s[left]) != char.ToLower(s[right]))
                    return false;

                left++;
                right--;
            }

            return true;
        }

        private bool IsValid(char c)
        {
            return char.IsDigit(c) || char.IsLetter(c);
        }
    }
}