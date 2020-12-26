using LeetCode.Common.Models;
using System;

namespace LeetCode.Q301_400
{
    public class Q337
    {
        public int Rob(TreeNode root)
        {
            int[] result = RobSub(root);
            return Math.Max(result[0], result[1]);
        }

        private int[] RobSub(TreeNode root)
        {
            if (root == null) return new int[2];

            int[] left = RobSub(root.left);
            int[] right = RobSub(root.right);

            // 0 = no rob, 1 = rob
            int[] res = new int[2];

            // no rob root, so can get the largest from left / right
            res[0] = Math.Max(left[0], left[1]) + Math.Max(right[0], right[1]);

            // rob root, thus get element 0 from left & right which is no rob
            res[1] = root.val + left[0] + right[0];

            return res;
        }
    }
}