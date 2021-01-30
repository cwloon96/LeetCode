namespace LeetCode.Q1_100
{
    public class Q79
    {
        public bool Exist(char[][] board, string word)
        {
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (board[i][j] == word[0])
                        if (BackTracking(board, word, i, j))
                            return true;
                }
            }

            return false;
        }

        private bool BackTracking(char[][] board, string word, int row, int col)
        {
            if (row < 0 || col < 0 || row >= board.Length || col >= board[row].Length)
                return false;

            if (board[row][col] == '0' || board[row][col] != word[0])
                return false;

            if (word.Length == 1)
                return board[row][col] == word[0];

            char temp = board[row][col];
            board[row][col] = '0';

            if (BackTracking(board, word.Substring(1), row, col + 1) ||
                BackTracking(board, word.Substring(1), row, col - 1) ||
                BackTracking(board, word.Substring(1), row + 1, col) ||
                BackTracking(board, word.Substring(1), row - 1, col))
                return true;

            board[row][col] = temp;

            return false;
        }
    }
}