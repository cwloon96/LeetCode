using LeetCode.Q601_700;
using NUnit.Framework;

namespace LeetCode.Test.Q601_700
{
    class Q665Test
    {
        [Test]
        public void Test()
        {
            bool result = new Q665().CheckPossibility(new[] { 4, 2, 3 });
            Assert.AreEqual(true, result);
        }
    }
}