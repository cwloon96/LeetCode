using LeetCode.Q1101_1200;
using NUnit.Framework;

namespace LeetCode.Test.Q1101_1200
{
    class Q1154Test
    {
        [Test]
        public void Test()
        {
            int result = new Q1154().DayOfYear("2004-03-01");
            Assert.AreEqual(61, result);
        }
    }
}