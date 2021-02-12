using LeetCode.Q601_700;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Test.Q601_700
{
    public class Q605Test
    {
        [Test]
        public void Test()
        {
            bool result = new Q605().CanPlaceFlowers(new[] { 0 }, 1);
            Assert.AreEqual(true, result);
        }

        [Test]
        public void Test2()
        {
            bool result = new Q605().CanPlaceFlowers(new[] { 1, 0, 0, 0, 1 }, 2);
            Assert.AreEqual(false, result);
        }

        [Test]
        public void TestNoMutate()
        {
            bool result = new Q605().CanPlaceFlowersNoMutate(new[] { 0 }, 1);
            Assert.AreEqual(true, result);
        }

        [Test]
        public void TestNoMutate2()
        {
            bool result = new Q605().CanPlaceFlowersNoMutate(new[] { 1, 0, 0, 0, 1 }, 2);
            Assert.AreEqual(false, result);
        }

        [Test]
        public void TestNoMutate3()
        {
            bool result = new Q605().CanPlaceFlowersNoMutate(new[] { 0 }, 2);
            Assert.AreEqual(false, result);
        }
    }
}