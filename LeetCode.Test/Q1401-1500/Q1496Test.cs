using LeetCode.Q1401_1500;
using NUnit.Framework;

namespace LeetCode.Test.Q1401_1500
{
    class Q1496Test
    {
        [Test]
        public void Test()
        {
            bool result = new Q1496().IsPathCrossing("NES");

            Assert.AreEqual(false, result);
        }
    }
}