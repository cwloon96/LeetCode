using LeetCode.Q601_700;
using NUnit.Framework;

namespace LeetCode.Test.Q601_700
{
    class Q696Test
    {
        [Test]
        public void Test()
        {
            int result = new Q696().CountBinarySubstrings("00110011");
            Assert.AreEqual(6, result);
        }
    }
}