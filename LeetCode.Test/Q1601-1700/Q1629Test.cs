using LeetCode.Q1601_1700;
using NUnit.Framework;

namespace LeetCode.Test.Q1601_1700
{
    class Q1629Test
    {
        [Test]
        public void Test()
        {
            char result = new Q1629().SlowestKey(new[] { 9, 29, 49, 50 }, "cbcd");

            Assert.AreEqual('c', result);
        }
    }
}
