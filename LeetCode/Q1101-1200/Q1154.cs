using System.Linq;

namespace LeetCode.Q1101_1200
{
    public class Q1154
    {
        public int DayOfYear(string date)
        {
            int[] dates = date.Split('-').Select(int.Parse).ToArray();
            int[] days = new[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (dates[0] % 4 == 0 && (dates[0] % 100 != 0 || dates[0] % 400 == 0))
                days[1] = 29;

            int day = 0;
            for (int i = 0; i < dates[1] - 1; i++)
                day += days[i];

            return day + dates[2];
        }
    }
}