using LeetCode.Q1501_1600;
using NUnit.Framework;

namespace LeetCode.Test.Q1501_1600
{
    class Q1544Test
    {
        [Test]
        public void Test()
        {
            string result = new Q1544().MakeGood("abBAcC");
            Assert.AreEqual("", result);
        }
    }
}