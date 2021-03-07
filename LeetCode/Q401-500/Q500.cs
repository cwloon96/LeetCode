using System;
using System.Collections.Generic;

namespace LeetCode.Q401_500
{
    public class Q500
    {
        public string[] FindWords(string[] words)
        {
            string[] keyboard = new[] { "qwertyuiop", "asdfghjkl", "zxcvbnm" };
            Dictionary<char, int> keyRow = new Dictionary<char, int>();
            List<string> result = new List<string>();

            for (int i = 0; i < keyboard.Length; i++)
                foreach (var key in keyboard[i])
                    keyRow.Add(key, i);

            foreach (var word in words)
            {
                int row = keyRow[Char.ToLower(word[0])];
                int i = 1;
                for (; i < word.Length; i++)
                    if (keyRow[Char.ToLower(word[i])] != row)
                        break;

                if (i == word.Length)
                    result.Add(word);
            }

            return result.ToArray();
        }
    }
}