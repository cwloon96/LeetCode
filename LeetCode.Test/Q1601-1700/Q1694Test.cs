using LeetCode.Q1601_1700;
using NUnit.Framework;

namespace LeetCode.Test.Q1601_1700
{
    class Q1694Test
    {
        [Test]
        public void Test()
        {
            string result = new Q1694().ReformatNumber("123 4-567");

            Assert.AreEqual("123-45-67", result);
        }
    }
}