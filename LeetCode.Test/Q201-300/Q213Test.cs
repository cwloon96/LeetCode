using LeetCode.Q201_300;
using NUnit.Framework;

namespace LeetCode.Test.Q201_300
{
    public class Q213Test
    {
        [Test]
        public void Test()
        {
            int result = new Q213().Rob(new[] { 1, 2, 3, 1 });
            Assert.AreEqual(4, result);
        }

        [Test]
        public void Test2()
        {
            int result = new Q213().Rob(new[] { 1 });
            Assert.AreEqual(1, result);
        }
    }
}