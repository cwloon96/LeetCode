using LeetCode.Q1001_1100;
using NUnit.Framework;

namespace LeetCode.Test.Q1001_1100
{
    class Q1078Test
    {
        [Test]
        public void Test()
        {
            string[] result = new Q1078().FindOcurrences("alice is a good girl she is a good student", "a", "good");
            string[] expected = new[] { "girl", "student" };
            CollectionAssert.AreEqual(expected, result);
        }
    }
}