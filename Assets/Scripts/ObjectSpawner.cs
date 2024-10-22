using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject[] objects; // Array de formas(cubo y esfera)
    public float spawnTime = 1.0f; 
    private float timer;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnTime)
        {
            SpawnObject();
            timer = 0;
        }
    }

    public void SpawnObject()
    {
        int index = Random.Range(0, objects.Length);
        Vector3 randomPosition = new Vector3(Random.Range(-5f, 5f), Random.Range(1f, 5f), Random.Range(1f, 5f));
        GameObject spawnedObject=Instantiate(objects[index], randomPosition, Quaternion.identity);
        Color randomColor = Random.ColorHSV();
        Renderer objectRenderer = spawnedObject.GetComponent<Renderer>();
        if (objectRenderer != null)
        {
            objectRenderer.material.color = randomColor;
        }
    }
}
