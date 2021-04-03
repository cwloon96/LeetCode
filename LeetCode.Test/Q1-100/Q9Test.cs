using LeetCode.Q1_100;
using NUnit.Framework;

namespace LeetCode.Test.Q1_100
{
    class Q9Test
    {
        [Test]
        public void Test()
        {
            var result = new Q9().IsPalindrome(121);

            Assert.AreEqual(true, result);
        }
    }
}