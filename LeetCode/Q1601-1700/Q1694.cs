using System.Text;

namespace LeetCode.Q1601_1700
{
    public class Q1694
    {
        public string ReformatNumber(string number)
        {
            StringBuilder sb = new StringBuilder();
            int index = 0;
            number = number.Replace("-", "").Replace(" ", "");

            while (index < number.Length)
            {
                int digitLeft = number.Length - index;
                if (digitLeft > 4)
                {
                    sb.Append(number.Substring(index, 3));
                    index += 3;
                    sb.Append("-");
                }
                else if (digitLeft == 4)
                {
                    sb.Append(number.Substring(index, 2));
                    index += 2;
                    sb.Append("-");

                    sb.Append(number.Substring(index, 2));
                    index += 2;
                    if (index < number.Length)
                        sb.Append("-");
                }
                else
                {
                    sb.Append(number.Substring(index));
                    index += digitLeft;
                }
            }

            return sb.ToString();
        }
    }
}