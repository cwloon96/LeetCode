using System.Collections.Generic;

namespace LeetCode.Q101_200
{
    public class Q131
    {
        public IList<IList<string>> Partition(string s)
        {
            IList<IList<string>> result = new List<IList<string>>();
            BackTracking(s, result, new List<string>());
            return result;
        }

        private void BackTracking(string s, IList<IList<string>> result, List<string> temp)
        {
            if (s.Length == 0)
                result.Add(new List<string>(temp));
            else
            {
                for (int length = 1; length <= s.Length; length++)
                {
                    string current = s.Substring(0, length);
                    if (IsPalindrome(current))
                    {
                        temp.Add(current);
                        BackTracking(s.Substring(length), result, temp);
                        temp.RemoveAt(temp.Count - 1);
                    }
                }
            }
        }

        private bool IsPalindrome(string s)
        {
            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                if (s[left] != s[right])
                    return false;

                left++;
                right--;
            }

            return true;
        }
    }
}