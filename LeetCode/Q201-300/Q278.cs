using LeetCode.Common.Models;

namespace LeetCode.Q201_300
{
    public class Q278 : VersionControl
    {
        public Q278(int badVersion) : base(badVersion)
        {
        }

        public int FirstBadVersion(int n)
        {
            int left = 1, right = n;
            while (left < right)
            {
                // left + right / 2 will cause overflow
                int mid = left + (right - left) / 2;

                if (!IsBadVersion(mid))
                    left = mid + 1;
                else
                    right = mid;
            }

            return left;
        }
    }
}