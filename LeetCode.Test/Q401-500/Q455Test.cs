using LeetCode.Q401_500;
using NUnit.Framework;

namespace LeetCode.Test.Q401_500
{
    class Q455Test
    {
        [Test]
        public void Test()
        {
            int result = new Q455().FindContentChildren(new[] { 2, 1 }, new[] {1,2,3 });
            Assert.AreEqual(2, result);
        }
    }
}