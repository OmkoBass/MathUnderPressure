using UnityEngine;
using TMPro;

public class TimerScript : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI timerText;

    void Start()
    {
        timerText.text = GameManager.TimerInitial.ToString("#.##");
    }

    void LateUpdate()
    {
        if (GameManager.GameOver)
        {
            return;
        }

        if (GameManager.Timer <= 0)
        {
            GameManager.GameOver = true;
        }

        GameManager.Timer -= Time.deltaTime;
        timerText.text = GameManager.Timer.ToString("#.##");
    }
}