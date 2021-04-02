using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Q801_900
{
    public class Q819
    {
        public string MostCommonWord(string paragraph, string[] banned)
        {
            Dictionary<string, int> ban = new Dictionary<string, int>();
            Dictionary<string, int> count = new Dictionary<string, int>();

            foreach (var word in banned)
                ban.Add(word, 1);

            char[] separators = new char[] { ' ', ';', ',', '.', '!', '?', '\'' };
            string[] words = paragraph.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words)
            {
                string lower = word.ToLower();
                if (!ban.ContainsKey(lower))
                {
                    if (count.ContainsKey(lower))
                        count[lower]++;
                    else
                        count[lower] = 1;
                }
            }

            return count.First(x => x.Value == count.Values.Max()).Key;
        }
    }
}