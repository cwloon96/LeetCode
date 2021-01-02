namespace LeetCode.Q901_1000
{
    public class Q941
    {
        public bool ValidMountainArray(int[] arr)
        {
            if (arr.Length == 1)
                return false;

            int i = 0;
            while (i < arr.Length - 1 && arr[i] < arr[i + 1])
                i++;

            if (i == 0 || i == arr.Length - 1)
                return false;

            while (i < arr.Length - 1 && arr[i] > arr[i + 1])
                i++;

            return i == arr.Length - 1;
        }
    }
}