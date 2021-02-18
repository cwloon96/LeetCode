using LeetCode.Common.Models;
using LeetCode.Q1_100;
using NUnit.Framework;

namespace LeetCode.Test.Q1_100
{
    class Q100Test
    {
        [Test]
        public void Test()
        {
            TreeNode treeA = new TreeNode(1);
            treeA.left = new TreeNode(2);
            treeA.right = new TreeNode(3);

            TreeNode treeB = new TreeNode(1);
            treeB.left = new TreeNode(2);
            treeB.right = new TreeNode(3);

            bool result = new Q100().IsSameTree(treeA, treeB);
            Assert.AreEqual(true, result);
        }
    }
}