using LeetCode.Q1_100;
using NUnit.Framework;

namespace LeetCode.Test.Q1_100
{
    public class Q7Test
    {
        [Test]
        public void Test()
        {
            int result = new Q7().Reverse(123);

            Assert.AreEqual(321, result);
        }

        [Test]
        public void Test2()
        {
            int result = new Q7().Reverse(1534236469);

            Assert.AreEqual(0, result);
        }
    }
}