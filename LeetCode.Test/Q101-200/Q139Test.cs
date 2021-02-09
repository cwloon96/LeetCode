using LeetCode.Q101_200;
using NUnit.Framework;
using System.Collections.Generic;

namespace LeetCode.Test.Q101_200
{
    public class Q139Test
    {
        [Test]
        public void Test()
        {
            bool result = new Q139().WordBreak("catsandog", new List<string> { "cats", "dog", "sand", "and", "cat" });
            Assert.AreEqual(false, result);
        }

        [Test]
        public void Test2()
        {
            bool result = new Q139().WordBreak("a", new List<string> { "a" });
            Assert.AreEqual(true, result);
        }

        [Test]
        public void Test3()
        {
            bool result = new Q139().WordBreak("ab", new List<string> { "a", "b" });
            Assert.AreEqual(true, result);
        }

        [Test]
        public void Test4()
        {
            bool result = new Q139().WordBreak("leetcode", new List<string> { "leet", "code" });
            Assert.AreEqual(true, result);
        }

        [Test]
        public void Test5()
        {
            bool result = new Q139().WordBreak("catsandog", new List<string> { "cats", "dog", "sand", "and", "cat" });
            Assert.AreEqual(false, result);
        }

        [Test]
        public void Test6()
        {
            bool result = new Q139().WordBreak("aaaaaaa", new List<string> { "aaaa", "aaa" });
            Assert.AreEqual(true, result);
        }

        [Test]
        public void Test7()
        {
            bool result = new Q139().WordBreak("abcdefg", new List<string> { "abc", "cde", "fg" });
            Assert.AreEqual(false, result);
        }
    }
}