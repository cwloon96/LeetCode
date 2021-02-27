using LeetCode.Q1701_1800;
using NUnit.Framework;

namespace LeetCode.Test.Q1701_1800
{
    class Q1732Test
    {
        [Test]
        public void Test()
        {
            int result = new Q1732().LargestAltitude(new[] { -5, 1, 5, 0, -7 });
            Assert.AreEqual(1, result);
        }
    }
}