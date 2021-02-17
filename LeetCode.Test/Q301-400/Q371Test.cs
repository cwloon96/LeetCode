using LeetCode.Q301_400;
using NUnit.Framework;

namespace LeetCode.Test.Q301_400
{
    class Q371Test
    {
        [Test]
        public void Test()
        {
            int result = new Q371().GetSum(1, 2);

            Assert.AreEqual(3, result);
        }
    }
}