using LeetCode.Q601_700;
using NUnit.Framework;

namespace LeetCode.Test.Q601_700
{
    class Q680Test
    {
        [Test]
        public void Test()
        {
            bool result = new Q680().ValidPalindrome("cbbcc");
            Assert.AreEqual(true, result);
        }
    }
}