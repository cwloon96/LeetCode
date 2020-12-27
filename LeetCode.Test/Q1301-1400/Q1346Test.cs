using LeetCode.Q1301_1400;
using NUnit.Framework;

namespace LeetCode.Test.Q1301_1400
{
    public class Q1346Test
    {
        [Test]
        public void Test()
        {
            bool result = new Q1346().CheckIfExist(new[] { 10, 2, 5, 3 });

            Assert.AreEqual(true, result);
        }
    }
}