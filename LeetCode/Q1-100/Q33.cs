namespace LeetCode.Q1_100
{
    public class Q33
    {
        public int Search(int[] nums, int target)
        {
            int pivot = FindPivot(nums, 0, nums.Length - 1);

            if (pivot == -1)
                return FindTarget(nums, target, 0, nums.Length - 1);

            if (nums[pivot] == target)
                return pivot;

            if (target >= nums[0])
                return FindTarget(nums, target, 0, pivot - 1);
            else
                return FindTarget(nums, target, pivot + 1, nums.Length - 1);
        }

        private int FindPivot(int[] nums, int left, int right)
        {
            if (left > right)
                return -1;

            int middle = (left + right) / 2;
            if (middle < nums.Length - 1 && nums[middle] > nums[middle + 1])
                return middle;

            if (nums[left] > nums[middle])
                return FindPivot(nums, left, middle - 1);

            return FindPivot(nums, middle + 1, right);
        }

        private int FindTarget(int[] nums, int target, int left, int right)
        {
            if (left > right)
                return -1;

            int middle = (left + right) / 2;

            if (nums[middle] == target)
                return middle;

            if (target > nums[middle])
                return FindTarget(nums, target, middle + 1, right);

            return FindTarget(nums, target, left, middle - 1);
        }
    }
}