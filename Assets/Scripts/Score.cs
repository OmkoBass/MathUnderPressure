using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    TextMeshProUGUI ScoreText;

    private void Start()
    {
        ScoreText = GetComponent<TextMeshProUGUI>();
    }

    private void FixedUpdate()
    {
        ScoreText.text = $"{GameManager.Score}";
    }
}
