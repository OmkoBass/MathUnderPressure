using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class GameOverMenuController : MonoBehaviour
{
    public Button ButtonRestart;
    public Button ButtonMainMenu;
    public Label LabelScore;
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;

        ButtonRestart = root.Q<Button>("ButtonRestart");
        ButtonMainMenu = root.Q<Button>("ButtonMainMenu");
        LabelScore = root.Q<Label>("LabelScore");


        ButtonRestart.clicked += Restart;
        ButtonMainMenu.clicked += MainMenu;
        LabelScore.text = $"Score: {GameManager.Score}";
    }

    void Restart() => SceneManager.LoadScene("GameScene");

    void MainMenu() => SceneManager.LoadScene("MainMenuScene");
}
