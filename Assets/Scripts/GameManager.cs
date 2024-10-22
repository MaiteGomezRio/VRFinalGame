using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public ObjectSpawner objectSpawner;
    public HUDManager hudManager;
    public GameTimer gameTimer;

    void Start()
    {
        // Inicializa el juego
        objectSpawner.SpawnObject();
        gameTimer.StartTimer();
    }
}
