using LeetCode.Q1401_1500;
using NUnit.Framework;

namespace LeetCode.Test.Q1401_1500
{
    class Q1470Test
    {
        [Test]
        public void Test()
        {
            int[] result = new Q1470().Shuffle(new[] { 2, 5, 1, 3, 4, 7 }, 3);

            int[] expected = new[] { 2, 3, 5, 4, 1, 7 };

            CollectionAssert.AreEqual(expected, result);
        }
    }
}