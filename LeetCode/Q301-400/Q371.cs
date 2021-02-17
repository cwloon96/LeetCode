namespace LeetCode.Q301_400
{
    public class Q371
    {
        public int GetSum(int a, int b)
        {
            /* in base 10 : 373 + 338 = 711
             * add without carry -> 601
             * add carry only -> 110
             * 601 + 110 = 711
            */

            /* in binary : 111 + 010 = 1001
             * add without carry -> 101 (XOR) a ^ b
             * add carry only -> 100 (AND, then shift 1 to left) (a & b) << 1
             * 101 + 100 = 1001
            */

            return b == 0 ? a : GetSum(a ^ b, (a & b) << 1);
        }
    }
}