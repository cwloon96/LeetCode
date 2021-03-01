using LeetCode.Q1701_1800;
using NUnit.Framework;

namespace LeetCode.Test.Q1701_1800
{
    class Q1736Test
    {
        [Test]
        public void Test()
        {
            string result = new Q1736().MaximumTime("2?:?0");
            Assert.AreEqual("23:50", result);
        }
    }
}