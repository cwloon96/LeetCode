using System.Text;

namespace LeetCode.Q1701_1800
{
    public class Q1736
    {
        public string MaximumTime(string time)
        {
            StringBuilder sb = new StringBuilder();

            if (time[0] == '?')
                if (time[1] == '?' || time[1] <= '3')
                    sb.Append("2");
                else
                    sb.Append("1");
            else
                sb.Append(time[0]);

            if (time[1] == '?')
                if (time[0] == '?' || time[0] == '2')
                    sb.Append("3");
                else
                    sb.Append("9");
            else
                sb.Append(time[1]);

            sb.Append(":");

            if (time[3] == '?')
                sb.Append("5");
            else
                sb.Append(time[3]);

            if (time[4] == '?')
                sb.Append("9");
            else
                sb.Append(time[4]);

            return sb.ToString();
        }
    }
}