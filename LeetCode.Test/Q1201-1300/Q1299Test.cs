using LeetCode.Q1201_1300;
using NUnit.Framework;

namespace LeetCode.Test.Q1201_1300
{
    class Q1299Test
    {
        [Test]
        public void Test()
        {
            int[] result = new Q1299().ReplaceElements(new[] { 17, 18, 5, 4, 6, 1 });

            Assert.AreEqual(18, result[0]);
            Assert.AreEqual(6, result[1]);
            Assert.AreEqual(6, result[2]);
            Assert.AreEqual(6, result[3]);
            Assert.AreEqual(1, result[4]);
            Assert.AreEqual(-1, result[5]);
        }
    }
}