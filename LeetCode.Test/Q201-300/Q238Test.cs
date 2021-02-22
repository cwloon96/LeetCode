using LeetCode.Q201_300;
using NUnit.Framework;

namespace LeetCode.Test.Q201_300
{
    class Q238Test
    {
        [Test]
        public void Test()
        {
            int[] result = new Q238().ProductExceptSelf(new[] { 1, 2, 3, 4 });

            int[] expected = new[] { 24, 12, 8, 6 };

            CollectionAssert.AreEqual(expected, result);
        }
    }
}