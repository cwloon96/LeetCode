using System.Collections.Generic;

namespace LeetCode.Q101_200
{
    public class LRUCache
    {
        private readonly LinkedList<int[]> _list;
        private readonly Dictionary<int, LinkedListNode<int[]>> _cache;
        private readonly int _capacity;

        public LRUCache(int capacity)
        {
            _cache = new Dictionary<int, LinkedListNode<int[]>>();
            _list = new LinkedList<int[]>();
            _capacity = capacity;
        }

        public int Get(int key)
        {
            if (_cache.ContainsKey(key))
            {
                Reorder(_cache[key]);
                return _cache[key].Value[1];
            }

            return -1;
        }

        public void Put(int key, int value)
        {
            if (_cache.ContainsKey(key))
                _cache[key].Value[1] = value;
            else
            {
                if (_cache.Count == _capacity)
                {
                    _cache.Remove(_list.First.Value[0]);
                    _list.RemoveFirst();
                }
                _cache.Add(key, new LinkedListNode<int[]>(new int[] { key, value }));
            }
            Reorder(_cache[key]);
        }

        private void Reorder(LinkedListNode<int[]> node)
        {
            // prevent remove if incoming node is new node
            if (node.Next != null) _list.Remove(node);
            if (_list.Last != node) _list.AddLast(node);
        }
    }

    public class CustomLRUCache
    {
        private readonly Dictionary<int, CustomLRUNode> _cache;
        private readonly CustomLRUNode _cacheHead;
        private readonly CustomLRUNode _cacheTail;
        private readonly int _capacity;

        public CustomLRUCache(int capacity)
        {
            _cache = new Dictionary<int, CustomLRUNode>();

            _cacheHead = new CustomLRUNode(-1, -1);
            _cacheTail = new CustomLRUNode(-1, -1);
            _cacheHead.Next = _cacheTail;
            _cacheTail.Prev = _cacheHead;

            _capacity = capacity;
        }

        public int Get(int key)
        {
            if (_cache.ContainsKey(key))
            {
                MoveToTail(key);
                return _cache[key].Data;
            }

            return -1;
        }

        public void Put(int key, int value)
        {
            if (_cache.ContainsKey(key))
            {
                MoveToTail(key);
                _cache[key].Data = value;
            }
            else
            {
                var newNode = new CustomLRUNode(key, value);
                PlaceTail(newNode);
                _cache[key] = newNode;
            }

            if (_cache.Count > _capacity)
            {
                _cache.Remove(_cacheHead.Next.Key);
                Remove(_cacheHead.Next);
            }
        }

        private void Remove(CustomLRUNode node)
        {
            node.Prev.Next = node.Next;
            node.Next.Prev = node.Prev;
        }

        private void PlaceTail(CustomLRUNode node)
        {
            node.Prev = _cacheTail.Prev;
            node.Next = _cacheTail;

            node.Prev.Next = node;
            node.Next.Prev = node;
        }

        private void MoveToTail(int key)
        {
            var node = _cache[key];
            Remove(node);
            PlaceTail(node);
        }

        class CustomLRUNode
        {
            public CustomLRUNode(int key, int data)
            {
                Key = key;
                Data = data;
            }

            public int Key { get; set; }
            public int Data { get; set; }
            public CustomLRUNode Next { get; set; }
            public CustomLRUNode Prev { get; set; }
        }
    }
}