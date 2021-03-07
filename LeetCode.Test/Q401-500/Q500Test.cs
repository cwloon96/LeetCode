using LeetCode.Q401_500;
using NUnit.Framework;

namespace LeetCode.Test.Q401_500
{
    class Q500Test
    {
        [Test]
        public void Test()
        {
            string[] result = new Q500().FindWords(new[] { "Hello", "Alaska", "Dad", "Peace" });
            string[] expected = new[] { "Alaska", "Dad" };
            CollectionAssert.AreEqual(expected, result);
        }
    }
}