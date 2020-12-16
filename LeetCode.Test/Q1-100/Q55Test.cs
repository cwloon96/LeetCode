using LeetCode.Q1_100;
using NUnit.Framework;

namespace LeetCode.Test.Q1_100
{
    public class Q55Test
    {
        [Test]
        public void Test()
        {
            bool result = new Q55().CanJump(new[] {2, 3, 1, 1, 4});

            Assert.AreEqual(true, result);
        }
    }
}