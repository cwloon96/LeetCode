using LeetCode.Q1_100;
using NUnit.Framework;

namespace LeetCode.Test.Q1_100
{
    public class Q20Test
    {
        [Test]
        public void Test()
        {
            bool result = new Q20().IsValid("()[]{}");

            Assert.AreEqual(true, result);
        }
    }
}