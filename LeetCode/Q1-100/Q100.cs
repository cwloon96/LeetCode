using LeetCode.Common.Models;

namespace LeetCode.Q1_100
{
    public class Q100
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
                return true;

            if (p == null || q == null)
                return false;

            if (!IsSameTree(p.left, q.left)) return false;
            if (!IsSameTree(p.right, q.right)) return false;

            return p.val == q.val;
        }
    }
}