using LeetCode.Q1_100;
using NUnit.Framework;

namespace LeetCode.Test.Q1_100
{
    public class Q79Test
    {
        [Test]
        public void Test()
        {
            bool result = new Q79().Exist(new char[][] {
                new char[] { 'A', 'B', 'C', 'E' },
                new char[] {'S', 'F', 'C', 'S' },
                new char[] {'A', 'D', 'E', 'E' } }, "ABCCED");

            Assert.AreEqual(true, result);
        }

        [Test]
        public void Test2()
        {
            bool result = new Q79().Exist(new char[][] {
                new char[] { 'A', 'B'  } }, "BA");

            Assert.AreEqual(true, result);
        }

        [Test]
        public void Test3()
        {
            bool result = new Q79().Exist(new char[][] {
                new char[] { 'A', 'A' } }, "AAA");

            Assert.AreEqual(false, result);
        }

        [Test]
        public void Test4()
        {
            bool result = new Q79().Exist(new char[][] {
                new char[] { 'A', 'B', 'C', 'E' },
                new char[] {'S', 'F', 'C', 'S' },
                new char[] {'A', 'D', 'E', 'E' } }, "SEE");

            Assert.AreEqual(true, result);
        }
    }
}