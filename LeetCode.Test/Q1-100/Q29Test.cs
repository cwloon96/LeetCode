using LeetCode.Q1_100;
using NUnit.Framework;

namespace LeetCode.Test.Q1_100
{
    class Q29Test
    {
        [Test]
        public void Test()
        {
            int result = new Q29().Divide(10, 3);
            Assert.AreEqual(3, result);
        }
    }
}