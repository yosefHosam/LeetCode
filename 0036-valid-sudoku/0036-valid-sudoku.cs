public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        HashSet<char> setRow = new HashSet<char>();

        for (int row = 0; row < board.Length; row++)
        {
            setRow.Clear();
            for (int col = 0; col < board[row].Length; col++)
            {
                if (board[row][col] == '.')
                    continue;

                if (!setRow.Add(board[row][col]))
                    return false;
            }
        }

        HashSet<char> setCol = new HashSet<char>();

        for (int col = 0; col < board.Length; col++)
        {
            setCol.Clear();
            for (int row = 0; row < board[col].Length; row++)
            {
                if (board[row][col] == '.')
                    continue;

                if (!setCol.Add(board[row][col]))
                    return false;
            }
        }

        HashSet<char> subBox = new HashSet<char>();

        for (int boxRow = 0; boxRow < board.Length; boxRow += 3)
        {
            for (int boxCol = 0; boxCol < board[boxRow].Length; boxCol += 3)
            {
                subBox.Clear();
                for (int row = boxRow; row < boxRow + 3; row++)
                {
                    for (int col = boxCol; col < boxCol + 3; col++)
                    {
                        if (board[row][col] == '.')
                            continue;

                        if (!subBox.Add(board[row][col]))
                            return false;
                    }
                }
            }
        }

        return true;
    }
}