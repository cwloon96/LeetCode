using System.Collections.Generic;

namespace LeetCode.Q401_500
{
    // Better description:
    // take an element in the first array and then find the same element in the second array and then look to the right in the second array to find a greater one.
    public class Q496
    {
        public int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            Stack<int> stack = new Stack<int>();
            Dictionary<int, int> dict = new Dictionary<int, int>();

            /*
             * 1. loop element from num2 into stack
             * 2. When found any number > stack.Peek(), means it will be the ans for the number in nums1
            */
            foreach (var num in nums2)
            {
                while (stack.Count > 0 && stack.Peek() < num)
                    dict.Add(stack.Pop(), num);
                stack.Push(num);
            }

            for (int i = 0; i < nums1.Length; i++)
                nums1[i] = dict.GetValueOrDefault(nums1[i], -1);

            return nums1;
        }
    }
}