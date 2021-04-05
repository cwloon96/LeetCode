namespace LeetCode.Common.Models
{
    public class VersionControl
    {
        private int _badVersion;

        public VersionControl(int badVersion)
        {
            _badVersion = badVersion;
        }

        protected bool IsBadVersion(int n) => n >= _badVersion;
    }
}