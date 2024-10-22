using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameTimer : MonoBehaviour
{
    public float timeLimit = 120f; // 2 minutos
    private float timeRemaining;
    public HUDManager hudManager; // Referencia al HUDManager
    
    public void StartTimer()
    {
        timeRemaining = timeLimit;
    }

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            hudManager.UpdateTimer(timeRemaining);

            if (timeRemaining <= 0)
            {
                Debug.Log("Game Over");
                SceneManager.LoadScene("EndScene");
            }
        }
    }
}
