using LeetCode.Q501_600;
using NUnit.Framework;

namespace LeetCode.Test.Q501_600
{
    class Q509Test
    {
        [Test]
        public void Test()
        {
            int result = new Q509().Fib(3);
            Assert.AreEqual(2, result);
        }
    }
}