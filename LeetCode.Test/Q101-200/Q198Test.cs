using LeetCode.Q101_200;
using NUnit.Framework;

namespace LeetCode.Test.Q101_200
{
    public class Q198Test
    {
        [Test]
        public void Test()
        {
            int result = new Q198().Rob(new[] { 1, 2, 3, 1 });
            Assert.AreEqual(0, result);
        }
    }
}