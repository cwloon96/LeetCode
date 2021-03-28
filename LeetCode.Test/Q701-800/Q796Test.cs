using LeetCode.Q701_800;
using NUnit.Framework;

namespace LeetCode.Test.Q701_800
{
    public class Q796Test
    {
        [Test]
        public void Test()
        {
            bool result = new Q796().RotateString("abcde", "cdeab");
            Assert.AreEqual(true, result);
        }
    }
}