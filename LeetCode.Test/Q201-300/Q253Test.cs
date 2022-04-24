using LeetCode.Q201_300;
using NUnit.Framework;

namespace LeetCode.Test.Q201_300
{
    class Q253Test
    {
        [Test]
        public void Test()
        {
            int result = new Q253().MinMeetingRoom(new int[][] { new[] { 9, 10 }, new[] { 4, 9 }, new[] { 5, 17 } });
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Test2()
        {
            int result = new Q253().MinMeetingRoom(new int[][] { new[] { 9, 10 }, new[] { 4, 9 }, new[] { 3, 4 } });
            Assert.AreEqual(1, result);
        }
    }
}