using LeetCode.Common.Models;
using LeetCode.Q301_400;
using NUnit.Framework;

namespace LeetCode.Test.Q301_400
{
    public class Q337Test
    {
        [Test]
        public void Test()
        {
            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(2);
            root.left.right = new TreeNode(3);

            root.right = new TreeNode(3);
            root.right.right = new TreeNode(1);

            int result = new Q337().Rob(root);
            Assert.AreEqual(7, result);
        }

        [Test]
        public void Test2()
        {
            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(4);
            root.left.left = new TreeNode(1);
            root.left.right = new TreeNode(3);

            root.right = new TreeNode(5);
            root.right.right = new TreeNode(1);

            int result = new Q337().Rob(root);
            Assert.AreEqual(9, result);
        }
    }
}