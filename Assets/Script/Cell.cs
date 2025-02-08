using UnityEngine;
using UnityEngine.UI;

public class Cell : MonoBehaviour
{
    public Button Button { get; private set; }
    public Text Text { get; private set; }

    private void Awake()
    {
        Button = GetComponent<Button>();
        Text = GetComponentInChildren<Text>();
    }
}
