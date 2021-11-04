using UnityEngine;
using TMPro;

public class GenerateProblem : MonoBehaviour
{
    [SerializeField]
    Rigidbody AnswerOnePlatform;

    [SerializeField]
    Rigidbody AnswerTwoPlatform;

    [SerializeField]
    TextMeshProUGUI ProblemText;

    [SerializeField]
    TextMeshProUGUI AnswerOneText;

    [SerializeField]
    TextMeshProUGUI AnswerTwoText;

    [SerializeField]
    TextAsset JsonFile;
    void Start()
    {
        Problems problems = JsonUtility.FromJson<Problems>(JsonFile.text);

        int randomSelection = Random.Range(0, problems.problems.Length - 1);

        ProblemText.text = problems.problems[randomSelection].problem;

        int chooseSide = Random.Range(0, 2);

        if (chooseSide == 0)
        {
            AnswerOnePlatform.tag = "AnswerTrue";
            AnswerTwoPlatform.tag = "AnswerFalse";

            AnswerTwoPlatform.mass = 1000;

            AnswerOneText.text = problems.problems[randomSelection].answerTrue;
            AnswerTwoText.text = problems.problems[randomSelection].answerFalse;
        }
        else
        {
            AnswerOnePlatform.tag = "AnswerFalse";
            AnswerTwoPlatform.tag = "AnswerTrue";

            AnswerOnePlatform.mass = 1000;

            AnswerOneText.text = problems.problems[randomSelection].answerFalse;
            AnswerTwoText.text = problems.problems[randomSelection].answerTrue;
        }
    }
}
