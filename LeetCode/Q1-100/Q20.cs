using System.Collections.Generic;

namespace LeetCode.Q1_100
{
    public class Q20
    {
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                char current = s[i];
                if (current == '(' || current == '{' || current == '[')
                {
                    stack.Push(current);
                }
                else
                {
                    if (stack.Count == 0)
                        return false;

                    char pop = stack.Pop();
                    if (pop == '(' && current != ')')
                        return false;
                    if (pop == '{' && current != '}')
                        return false;
                    if (pop == '[' && current != ']')
                        return false;
                }
            }

            return stack.Count == 0;
        }
    }
}