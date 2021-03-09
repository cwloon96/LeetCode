using LeetCode.Q401_500;
using NUnit.Framework;

namespace LeetCode.Test.Q401_500
{
    class Q496Test
    {
        [Test]
        public void Test()
        {
            int[] result = new Q496().NextGreaterElement(new[] { 4, 1, 2 }, new[] { 1, 3, 4, 2 });
            int[] expected = new[] { -1, 3, -1 };
            CollectionAssert.AreEqual(expected, result);
        }
    }
}