using LeetCode.Q1101_1200;
using NUnit.Framework;

namespace LeetCode.Test.Q1101_1200
{
    class Q1108Test
    {
        [Test]
        public void Test()
        {
            string result = new Q1108().DefangIPaddr("1.1.1.1");
            Assert.AreEqual("1[.]1[.]1[.]1", result);
        }
    }
}