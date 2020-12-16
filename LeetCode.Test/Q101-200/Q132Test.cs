using LeetCode.Q101_200;
using NUnit.Framework;

namespace LeetCode.Test.Q101_200
{
    public class Q132Test
    {
        [Test]
        public void Test()
        {
            int result = new Q132().MinCut("aabaa");
            Assert.AreEqual(0, result);
        }
    }
}