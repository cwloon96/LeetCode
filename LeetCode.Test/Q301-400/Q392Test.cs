using LeetCode.Q301_400;
using NUnit.Framework;

namespace LeetCode.Test.Q301_400
{
    class Q392Test
    {
        [Test]
        public void Test()
        {
            bool result = new Q392().IsSubsequence("abc", "ahbgdc");

            Assert.AreEqual(true, result);
        }
    }
}