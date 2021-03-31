using LeetCode.Q301_400;
using NUnit.Framework;

namespace LeetCode.Test.Q301_400
{
    class Q345Test
    {
        [Test]
        public void Test()
        {
            string result = new Q345().ReverseVowels("aA");

            Assert.AreEqual("Aa", result);
        }
    }
}