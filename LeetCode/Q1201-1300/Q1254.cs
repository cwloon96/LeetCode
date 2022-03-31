namespace LeetCode.Q1201_1300
{
    public class Q1254
    {
        public int ClosedIsland(int[][] grid)
        {
            int result = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 0)
                    {
                        if (IsClosed(grid, i, j))
                            result++;
                    }
                }
            }

            return result;
        }

        private bool IsClosed(int[][] grid, int row, int col)
        {
            if (row < 0 || row >= grid.Length ||
                col < 0 || col >= grid[row].Length)
                return false;

            if (grid[row][col] == 1)
                return true;

            grid[row][col] = 1;

            bool result = true;

            if (!IsClosed(grid, row + 1, col))
                result = false;

            if (!IsClosed(grid, row - 1, col))
                result = false;

            if (!IsClosed(grid, row, col + 1))
                result = false;

            if (!IsClosed(grid, row, col - 1))
                result = false;

            return result;
        }
    }
}