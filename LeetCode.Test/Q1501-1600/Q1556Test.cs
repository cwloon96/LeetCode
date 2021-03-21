using LeetCode.Q1501_1600;
using NUnit.Framework;

namespace LeetCode.Test.Q1501_1600
{
    class Q1556Test
    {
        [Test]
        public void Test()
        {
            string result = new Q1556().ThousandSeparator(1234);
            Assert.AreEqual("1.234", result);
        }
    }
}