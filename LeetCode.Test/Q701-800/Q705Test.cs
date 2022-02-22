using LeetCode.Q701_800;
using NUnit.Framework;

namespace LeetCode.Test.Q701_800
{
    class Q705Test
    {
        [Test]
        public void Test()
        {
            var set = new MyHashSet();
            set.Add(1);
            set.Add(31);
            set.Add(81);
            set.Add(1011);

            Assert.AreEqual(true, set.Contains(1));
            Assert.AreEqual(true, set.Contains(31));
            Assert.AreEqual(true, set.Contains(81));
            Assert.AreEqual(true, set.Contains(1011));

            Assert.AreEqual(false, set.Contains(2));

            set.Remove(1);
            Assert.AreEqual(false, set.Contains(1));
        }
    }
}