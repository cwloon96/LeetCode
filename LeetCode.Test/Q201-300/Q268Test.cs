using LeetCode.Q201_300;
using NUnit.Framework;

namespace LeetCode.Test.Q201_300
{
    public class Q268Test
    {
        [Test]
        public void Test()
        {
            int result = new Q268().MissingNumber(new[] { 3, 0, 1 });
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Test2()
        {
            int result = new Q268().MissingNumber(new[] { 0, 1 });
            Assert.AreEqual(2, result);
        }
    }
}