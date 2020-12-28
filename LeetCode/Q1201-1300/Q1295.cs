using System.Linq;

namespace LeetCode.Q1201_1300
{
    public class Q1295
    {
        public int FindNumbers(int[] nums)
        {
            return nums.Count(x => x.ToString().Length % 2 == 0);
        }
    }
}