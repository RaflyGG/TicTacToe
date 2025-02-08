using UnityEngine;
using UnityEngine.UI;

public class GameManagers : MonoBehaviour
{
    public Cell[] cells;
    public Text winMessage;
    public Button resetButton;

    private IPlayer playerX;
    private IPlayer playerO;
    private IPlayer currentPlayer;
    private IWinChecker winChecker;
    private IResettable resettable;

    private int moveCount;

    private void Start()
    {
        playerX = new PlayerX();
        playerO = new PlayerO();
        currentPlayer = playerX;
        winChecker = new WinChecker();
        resettable = new Resettable(cells);

        resetButton.onClick.AddListener(ResetGame);

        foreach (var cell in cells)
        {
            cell.Button.onClick.AddListener(() => CellClicked(cell));
        }
    }

    private void CellClicked(Cell cell)
    {
        if (cell.Text.text == "")
        {
            currentPlayer.SetSymbol(cell);
            moveCount++;

            if (winChecker.CheckWin(cells, currentPlayer.Symbol))
            {
                EndGame(currentPlayer.Symbol);
            }
            else if (moveCount == 9)
            {
                EndGame("Draw");
            }
            else
            {
                currentPlayer = currentPlayer == playerX ? playerO : playerX;
            }
        }
    }

    private void EndGame(string result)
    {
        winMessage.text = result == "Draw" ? "Draw!" : $"{result} wins!";
        winMessage.gameObject.SetActive(true);

        foreach (var cell in cells)
        {
            cell.Button.interactable = false;
        }
    }

    private void ResetGame()
    {
        currentPlayer = playerX;
        moveCount = 0;
        winMessage.gameObject.SetActive(false);
        resettable.Reset();
    }
}
