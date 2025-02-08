public class PlayerO : IPlayer
{
    public string Symbol => "O";

    public void SetSymbol(Cell cell)
    {
        cell.Text.text = Symbol;
    }
}