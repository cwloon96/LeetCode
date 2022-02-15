using LeetCode.Q101_200;
using NUnit.Framework;

namespace LeetCode.Test.Q101_200
{
    class Q179Test
    {
        [Test]
        public void Test()
        {
            string result = new Q179().LargestNumber(new int[] { 3, 30, 34, 5, 9 });
            Assert.AreEqual("9534330", result);
        }
    }
}