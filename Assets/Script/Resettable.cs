public class Resettable : IResettable
{
    private Cell[] cells;

    public Resettable(Cell[] cells)
    {
        this.cells = cells;
    }

    public void Reset()
    {
        foreach (var cell in cells)
        {
            cell.Text.text = "";
            cell.Button.interactable = true;
        }
    }
}
