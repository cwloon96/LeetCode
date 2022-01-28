using LeetCode.Q201_300;
using NUnit.Framework;

namespace LeetCode.Test.Q201_300
{
    public class Q211Test
    {
        [Test]
        public void Test()
        {
            var dict = new WordDictionary();
            dict.AddWord("bad");
            dict.AddWord("dad");
            dict.AddWord("mad");

            Assert.AreEqual(false, dict.Search("pad"));
            Assert.AreEqual(true, dict.Search("bad"));
            Assert.AreEqual(true, dict.Search(".ad"));
            Assert.AreEqual(true, dict.Search("b.."));
        }
    }
}