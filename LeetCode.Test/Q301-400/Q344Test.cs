using LeetCode.Q301_400;
using NUnit.Framework;

namespace LeetCode.Test.Q301_400
{
    class Q344Test
    {
        [Test]
        public void Test()
        {
            char[] arr = new[] {'h', 'e', 'l', 'l', 'o' };
            new Q344().ReverseString(arr);

            Assert.AreEqual('o', arr[0]);
            Assert.AreEqual('l', arr[1]);
            Assert.AreEqual('l', arr[2]);
            Assert.AreEqual('e', arr[3]);
            Assert.AreEqual('h', arr[4]);
        }
    }
}