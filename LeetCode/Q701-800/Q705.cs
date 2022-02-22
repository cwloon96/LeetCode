namespace LeetCode.Q701_800
{
    public class MyHashSet
    {
        private readonly int[] _nums;

        public MyHashSet()
        {
            // max value is 1000000
            // we will store 32 value in each index
            // eg: 0 = 0 - 31, 1 = 32 - 63
            // 1000000 / 32 = 31250
            _nums = new int[31251];
        }

        public void Add(int key)
        {
            _nums[GetIndex(key)] |= GetMask(key);
        }

        public void Remove(int key)
        {
            _nums[GetIndex(key)] &= ~GetMask(key);
        }

        public bool Contains(int key)
        {
           return (_nums[GetIndex(key)] & GetMask(key)) != 0;
        }

        private int GetIndex(int key) => key / 32;

        private int GetMask(int key)
        {
            key %= 32;
            return (1 << key);
        }
    }
}