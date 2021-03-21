using System.Text;

namespace LeetCode.Q1501_1600
{
    public class Q1556
    {
        public string ThousandSeparator(int n)
        {
            if (n < 1000)
                return n.ToString();

            StringBuilder sb = new StringBuilder();

            int digit = 0;
            while (n > 0)
            {
                sb.Insert(0, n % 10);

                digit++;
                // n >= 10 to check if n is first digit, if yes then not going to add dot
                if (digit % 3 == 0 && n >= 10)
                    sb.Insert(0, '.');

                n /= 10;
            }

            return sb.ToString();
        }
    }
}