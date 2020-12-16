using LeetCode.Q1_100;
using NUnit.Framework;

namespace LeetCode.Test.Q1_100
{
    public class Q33Test
    {
        [Test]
        public void Test()
        {
            int result = new Q33().Search(new[] { 8, 9, 2, 3, 4 }, 9);
            Assert.AreEqual(1, result);
        }
    }
}