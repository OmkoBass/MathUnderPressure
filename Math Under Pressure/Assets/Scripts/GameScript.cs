using UnityEngine;
using TMPro;

public class GameScript : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI TextProblem;

    [SerializeField]
    TextMeshProUGUI TextAnswerOne;

    [SerializeField]
    TextMeshProUGUI TextAnswerTwo;

    [SerializeField]
    TextAsset JsonFile;

    [SerializeField]
    GameObject PanelGameOver;

    private void Start()
    {
        GameManager.Timer = GameManager.TimerInitial;
        GameManager.Score = 0;
        GenerateProblem.GenerateNewProblem(JsonFile.text);
        UpdateUI();
        GameManager.GameOver = false;
    }

    void Update()
    {
        if (GameManager.GameOver)
        {
            PanelGameOver.gameObject.SetActive(true);
            return;
        }
        else
        {
            PanelGameOver.gameObject.SetActive(false);
        }

        Problem problem = GameManager.CurrentProblem;

        string inputString = Input.inputString;
        if (inputString != null)
        {
            if (inputString == "a")
            {
                if (TextAnswerOne.text == problem.answerTrue)
                {
                    CorrectAnswer();
                }
                else
                {
                    GameManager.GameOver = true;
                }
            }
            else if (inputString == "d")
            {
                if (TextAnswerTwo.text == problem.answerTrue)
                {
                    CorrectAnswer();
                }
                else
                {
                    GameManager.GameOver = true;
                }
            }
        }
    }

    void CorrectAnswer()
    {
        GameManager.Score++;
        GameManager.Timer = GameManager.TimerInitial;
        GenerateProblem.GenerateNewProblem(JsonFile.text);

        UpdateUI();
    }

    void UpdateUI()
    {
        Problem problem = GameManager.CurrentProblem;

        int chooseSide = Random.Range(0, 2);

        TextProblem.text = GameManager.CurrentProblem.problem;

        if (chooseSide == 0)
        {
            TextAnswerOne.text = problem.answerTrue;
            TextAnswerTwo.text = problem.answerFalse;
        }
        else
        {
            TextAnswerOne.text = problem.answerFalse;
            TextAnswerTwo.text = problem.answerTrue;
        }
    }
}
