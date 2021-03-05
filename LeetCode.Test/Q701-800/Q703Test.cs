using LeetCode.Q701_800;
using NUnit.Framework;

namespace LeetCode.Test.Q701_800
{
    class Q703Test
    {
        [Test]
        public void Test()
        {
            var obj = new KthLargest(2, new[] { 0 });
            Assert.AreEqual(-1, obj.Add(-1));
            Assert.AreEqual(0, obj.Add(1));
            Assert.AreEqual(0, obj.Add(-2));
            Assert.AreEqual(0, obj.Add(-4));
            Assert.AreEqual(1, obj.Add(3));
        }
    }
}