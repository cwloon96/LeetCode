using System.Text;

namespace LeetCode.Q1101_1200
{
    public class Q1108
    {
        public string DefangIPaddr(string address)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in address)
            {
                if (c == '.')
                    sb.Append("[.]");
                else
                    sb.Append(c);
            }

            return sb.ToString();
        }
    }
}