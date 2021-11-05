using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public Button StartButton;
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;

        StartButton = root.Q<Button>("StartButton");

        StartButton.clicked += StartGame;
    }

    void StartGame() => SceneManager.LoadScene("GameScene");
}
