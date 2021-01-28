using LeetCode.Q601_700;
using NUnit.Framework;

namespace LeetCode.Test.Q601_700
{
    class Q647Test
    {
        [Test]
        public void Test()
        {
            int result = new Q647().CountSubstrings("aaa");
            Assert.AreEqual(6, result);
        }
    }
}