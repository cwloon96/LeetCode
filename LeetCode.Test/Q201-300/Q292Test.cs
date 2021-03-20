using LeetCode.Q201_300;
using NUnit.Framework;

namespace LeetCode.Test.Q201_300
{
    class Q292Test
    {
        [Test]
        public void Test()
        {
            bool result = new Q292().CanWinNim(4);
            Assert.AreEqual(false, result);
        }
    }
}