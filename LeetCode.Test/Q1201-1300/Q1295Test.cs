using LeetCode.Q1201_1300;
using NUnit.Framework;

namespace LeetCode.Test.Q1201_1300
{
    class Q1295Test
    {
        [Test]
        public void Test()
        {
            int result = new Q1295().FindNumbers(new[] { 555, 901, 482, 1771 });

            Assert.AreEqual(1, result);
        }
    }
}