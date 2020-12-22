namespace LeetCode.Q601_700
{
    public class Q605
    {
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            for (int i = 0; i < flowerbed.Length; i++)
            {
                if (n == 0)
                    break;

                if (flowerbed[i] == 0)
                {
                    if (i > 0 && flowerbed[i - 1] == 1)
                        continue;

                    if (i < flowerbed.Length - 1 && flowerbed[i + 1] == 1)
                        continue;

                    flowerbed[i] = 1;
                    n--;
                }
            }

            return n == 0;
        }

        public bool CanPlaceFlowersNoMutate(int[] flowerbed, int n)
        {
            int currentEmpty = 0;
            for (int i = 0; i <= flowerbed.Length; i++)
            {
                // i < flowerbed.Length force it go to else statement after reaching last element
                if (i < flowerbed.Length && flowerbed[i] == 0)
                {
                    currentEmpty++;

                    // separate to two if statement to fit the case [0]
                    // to represent left of first element or right of last element
                    if (i == 0) currentEmpty++;
                    if (i == flowerbed.Length - 1) currentEmpty++;
                }
                else
                {
                    // if 3 zero in a row, only 1 slot can be placed
                    n -= (currentEmpty - 1) / 2;
                    if (n <= 0) return true;
                    currentEmpty = 0;
                }
            }

            return false;
        }
    }
}