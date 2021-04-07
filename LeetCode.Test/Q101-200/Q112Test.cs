using LeetCode.Common.Models;
using LeetCode.Q101_200;
using NUnit.Framework;

namespace LeetCode.Test.Q101_200
{
    class Q112Test
    {
        [Test]
        public void Test()
        {
            TreeNode root = new TreeNode(1, new TreeNode(2));
            bool result = new Q112().HasPathSum(root, 1);

            Assert.AreEqual(false, result);
        }
    }
}