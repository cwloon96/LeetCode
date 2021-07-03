using LeetCode.Q201_300;
using NUnit.Framework;

namespace LeetCode.Test.Q201_300
{
    public class Q215Test
    {
        [Test]
        public void Test()
        {
            int result = new Q215().FindKthLargest(new[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 }, 9);
            Assert.AreEqual(1, result);
        }
    }
}