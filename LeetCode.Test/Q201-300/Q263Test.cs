using LeetCode.Q201_300;
using NUnit.Framework;

namespace LeetCode.Test.Q201_300
{
    class Q263Test
    {
        [Test]
        public void Test()
        {
            bool result = new Q263().IsUgly(6);
            Assert.AreEqual(true, result);
        }
    }
}