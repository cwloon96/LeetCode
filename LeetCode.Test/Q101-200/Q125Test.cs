using LeetCode.Q101_200;
using NUnit.Framework;

namespace LeetCode.Test.Q101_200
{
    class Q125Test
    {
        [Test]
        public void Test()
        {
            bool result = new Q125().IsPalindrome("A man, a plan, a canal: Panama");
            Assert.AreEqual(true, result);
        }
    }
}