using System.Collections.Generic;

namespace LeetCode.Q301_400
{
    public class Q345
    {
        public string ReverseVowels(string s)
        {
            List<char> vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };
            int left = 0;
            int right = s.Length - 1;
            char[] arr = s.ToCharArray();
            while (left < right)
            {
                while (left < right && !vowels.Contains(char.ToLower(s[left])))
                    left++;

                while (left < right && !vowels.Contains(char.ToLower(s[right])))
                    right--;

                if (left < right)
                {
                    var temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                }
                left++;
                right--;
            }

            return new string(arr);
        }
    }
}