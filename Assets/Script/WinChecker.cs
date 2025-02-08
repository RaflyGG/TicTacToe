public class WinChecker : IWinChecker
{
    public bool CheckWin(Cell[] cells, string symbol)
    {
        // Check rows
        for (int i = 0; i < 3; i++)
        {
            if (cells[i * 3].Text.text == symbol &&
                cells[i * 3 + 1].Text.text == symbol &&
                cells[i * 3 + 2].Text.text == symbol)
            {
                return true;
            }
        }

        // Check columns
        for (int i = 0; i < 3; i++)
        {
            if (cells[i].Text.text == symbol &&
                cells[i + 3].Text.text == symbol &&
                cells[i + 6].Text.text == symbol)
            {
                return true;
            }
        }

        // Check diagonals
        if (cells[0].Text.text == symbol &&
            cells[4].Text.text == symbol &&
            cells[8].Text.text == symbol)
        {
            return true;
        }

        if (cells[2].Text.text == symbol &&
            cells[4].Text.text == symbol &&
            cells[6].Text.text == symbol)
        {
            return true;
        }

        return false;
    }
}
