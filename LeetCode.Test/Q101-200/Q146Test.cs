using LeetCode.Q101_200;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Test.Q101_200
{
    class Q146Test
    {
        [Test]
        public void LRUCache_Test()
        {
            var cache = new LRUCache(5);
            cache.Put(1, 10);
            cache.Put(3, 30);

            cache.Put(4, 40);
            Assert.AreEqual(40, cache.Get(4));

            cache.Put(1, 5);
            Assert.AreEqual(5, cache.Get(1));

            cache.Put(2, 20);
            cache.Put(6, 60);
            cache.Put(7, 70);

            Assert.AreEqual(-1, cache.Get(3));
        }


        [Test]
        public void CustomLRUCache_Test()
        {
            var cache = new CustomLRUCache(1);
            cache.Put(1, 10);
            cache.Put(3, 30);

            cache.Put(4, 40);
            Assert.AreEqual(40, cache.Get(4));

            cache.Put(1, 5);
            Assert.AreEqual(5, cache.Get(1));

            cache.Put(2, 20);
            cache.Put(6, 60);
            cache.Put(7, 70);

            Assert.AreEqual(-1, cache.Get(3));
        }
    }
}