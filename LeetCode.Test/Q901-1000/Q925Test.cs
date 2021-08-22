using LeetCode.Q901_1000;
using NUnit.Framework;

namespace LeetCode.Test.Q901_1000
{
    class Q925Test
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual(true, new Q925().IsLongPressedName("alex", "aaleex"));
        }


        [Test]
        public void Test2()
        {
            Assert.AreEqual(false, new Q925().IsLongPressedName("alex", "aaleexa"));
        }


        [Test]
        public void Test3()
        {
            Assert.AreEqual(false, new Q925().IsLongPressedName("saeed", "ssaaedd"));
        }
    }
}