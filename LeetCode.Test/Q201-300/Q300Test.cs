using LeetCode.Q201_300;
using NUnit.Framework;

namespace LeetCode.Test.Q201_300
{
    public class Q300Test
    {
        [Test]
        public void Test()
        {
            int result = new Q300().LengthOfLIS(new[] { 10, 9, 2, 5, 3, 7, 101, 18 });
            Assert.AreEqual(4, result);
        }
    }
}