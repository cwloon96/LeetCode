using LeetCode.Q401_500;
using NUnit.Framework;

namespace LeetCode.Test.Q401_500
{
    class Q414Test
    {
        [Test]
        public void Test()
        {
            int result = new Q414().ThirdMax(new[] { 2, 1 });
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Test2()
        {
            int result = new Q414().ThirdMax(new[] { 3, 2, 1 });
            Assert.AreEqual(1, result);
        }
    }
}