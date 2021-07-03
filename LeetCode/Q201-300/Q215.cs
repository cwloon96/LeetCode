namespace LeetCode.Q201_300
{
    public class Q215
    {
        public int FindKthLargest(int[] nums, int k)
        {
            var heap = new MinHeap(k);
            for (int i = 0; i < nums.Length; i++)
                heap.Insert(nums[i]);

            return heap.Peek();
        }
    }

    public class MinHeap
    {
        private int[] _elements;
        private int _size;

        public MinHeap(int size)
        {
            _elements = new int[size];
        }

        public void Insert(int element)
        {
            if (_size == _elements.Length)
            {
                if (element > Peek())
                {
                    Pop();
                    Insert(element);
                }
            }
            else
            {
                _elements[_size++] = element;
                AdjustUp();
            }
        }

        public int Peek() => _elements[0];

        private int Pop()
        {
            int result = _elements[0];
            _elements[0] = _elements[_size - 1];
            _size--;

            AdjustDown();

            return result;
        }

        private void AdjustUp()
        {
            int index = _size - 1;
            int temp = _elements[index];

            while (index > 0 && temp < _elements[GetParentIndex(index)])
            {
                _elements[index] = _elements[GetParentIndex(index)];
                index = GetParentIndex(index);
            }

            _elements[index] = temp;
        }

        private void AdjustDown()
        {
            int index = 0;

            while (HasLeftChild(index))
            {
                int smallerIndex = GetLeftChildIndex(index);

                if (HasRightChild(index) && _elements[GetRightChildIndex(index)] < _elements[GetLeftChildIndex(index)])
                {
                    smallerIndex = GetRightChildIndex(index);
                }

                if (_elements[index] < _elements[smallerIndex])
                {
                    break;
                }

                int temp = _elements[index];
                _elements[index] = _elements[smallerIndex];
                _elements[smallerIndex] = temp;
                index = smallerIndex;
            }
        }

        private int GetParentIndex(int index) => (index - 1) / 2;
        private int GetLeftChildIndex(int index) => index * 2 + 1;
        private int GetRightChildIndex(int index) => index * 2 + 2;

        private bool HasLeftChild(int index) => GetLeftChildIndex(index) < _size;
        private bool HasRightChild(int index) => GetRightChildIndex(index) < _size;
    }
}