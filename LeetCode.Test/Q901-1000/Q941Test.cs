using LeetCode.Q901_1000;
using NUnit.Framework;

namespace LeetCode.Test.Q901_1000
{
    public class Q941Test
    {
        [Test]
        public void Test()
        {
            bool result = new Q941().ValidMountainArray(new[] { 2, 1 });

            Assert.AreEqual(false, result);
        }

        [Test]
        public void Test2()
        {
            bool result = new Q941().ValidMountainArray(new[] { 3, 5, 5 });

            Assert.AreEqual(false, result);
        }

        [Test]
        public void Test3()
        {
            bool result = new Q941().ValidMountainArray(new[] { 0, 3, 2, 1 });

            Assert.AreEqual(true, result);
        }
    }
}