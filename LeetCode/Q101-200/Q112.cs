using LeetCode.Common.Models;

namespace LeetCode.Q101_200
{
    public class Q112
    {
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null)
                return false;

            if (root.left == null && root.right == null)
                return targetSum - root.val == 0;

            return HasPathSum(root.left, targetSum - root.val) || HasPathSum(root.right, targetSum - root.val);
        }
    }
}