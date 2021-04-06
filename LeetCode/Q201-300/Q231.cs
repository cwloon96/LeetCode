namespace LeetCode.Q201_300
{
    public class Q231
    {
        public bool IsPowerOfTwo_Bit(int n)
        {
            /* All power 2 = got only 1 bit = 1
             * 2 = 0000 0010, 1 = 0000 0001 
             * 4 = 0000 0100, 3 = 0000 0011
             * thus n & (n - 1) will get 0000 0000
            */
            return n > 0 && (n & (n - 1)) == 0;
        }

        public bool IsPowerOfTwo_Loop(int n)
        {
            if (n <= 0) return false;

            while (n % 2 == 0)
                n /= 2;
            
            return n == 1;
        }
    }
}