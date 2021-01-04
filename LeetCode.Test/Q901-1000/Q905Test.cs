using LeetCode.Q901_1000;
using NUnit.Framework;

namespace LeetCode.Test.Q901_1000
{
    class Q905Test
    {
        [Test]
        public void Test()
        {
            int[] result = new Q905().SortArrayByParity(new[] { 3, 1, 2, 4 });

            Assert.AreEqual(2, result[0]);
            Assert.AreEqual(4, result[1]);
            Assert.AreEqual(3, result[2]);
            Assert.AreEqual(1, result[3]);
        }
    }
}