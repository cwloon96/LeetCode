using System.Collections.Generic;
using System.Linq;

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

        public bool IsSubsequence_FollowUp(string s, string t)
        {
            var arr = new List<int>[26];

            for (int i = 0; i < t.Length; i++)
            {
                int index = t[i] - 'a';
                if (arr[index] == null)
                    arr[index] = new List<int>();

                arr[index].Add(i);
            }

            int lastIndex = -1;
            for (int i = 0; i < s.Length; i++)
            {
                int index = s[i] - 'a';
                if (arr[index] == null || !arr[index].Any(x => x > lastIndex))
                    return false;

                lastIndex = arr[index].FirstOrDefault(x => x > lastIndex);
            }

            return true;
        }
    }
}