using LeetCode.Q201_300;
using NUnit.Framework;

namespace LeetCode.Test.Q201_300
{
    class Q278Test
    {
        [Test]
        public void Test()
        {
            int result = new Q278(4).FirstBadVersion(5);
            Assert.AreEqual(4, result);
        }
    }
}