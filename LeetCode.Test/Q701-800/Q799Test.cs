using LeetCode.Q701_800;
using NUnit.Framework;

namespace LeetCode.Test.Q701_800
{
    class Q799Test
    {
        [Test]
        public void Test()
        {
            double result = new Q799().ChampagneTower(6, 3, 1);
            Assert.AreEqual(0.25, result);
        }
    }
}