using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Q1501_1600
{
    public class Q1544
    {
        public string MakeGood(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (var c in s)
            {
                if (stack.Count == 0)
                    stack.Push(c);
                else
                {
                    if (Math.Abs(stack.Peek() - c) == 32)
                        stack.Pop();
                    else
                        stack.Push(c);
                }
            }

            StringBuilder result = new StringBuilder();
            while (stack.Count > 0)
                result.Insert(0, stack.Pop());

            return result.ToString();
        }
    }
}