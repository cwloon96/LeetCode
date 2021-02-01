using LeetCode.Q201_300;
using NUnit.Framework;

namespace LeetCode.Test.Q201_300
{
    class Q217Test
    {
        [Test]
        public void Test()
        {
            bool result = new Q217().ContainsDuplicate(new[] { 1, 2, 3, 1 });
            Assert.AreEqual(true, result);
        }
    }
}