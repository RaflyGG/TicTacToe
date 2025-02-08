public class PlayerX : IPlayer
{
    public string Symbol => "X";

    public void SetSymbol(Cell cell)
    {
        cell.Text.text = Symbol;
    }
}