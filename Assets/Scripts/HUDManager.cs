
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour
{

    public TextMeshProUGUI scoreText; 
    public TextMeshProUGUI timerText; 
    private int score = 0;

    public void UpdateScore()
    {
        score++;
        scoreText.text = "Score: " + score.ToString();
    }

    public void UpdateTimer(float timeRemaining)
    {
        timerText.text = "Time: " + Mathf.Round(timeRemaining).ToString();
    }

    
}
