using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private float spawnInterval = 1f;
    public GameObject enemyPrefab; // Reference to the object to instantiate
    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;

        InvokeRepeating("SpawnEnemy", 0f, spawnInterval); // Invoke the SpawnObject method every 1 second starting immediately
    }

    void SpawnEnemy()
    {
        Vector3 spawnPosition = GetRandomSpawnPosition();

        // Instantiate the object at the random position
        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }

    Vector3 GetRandomSpawnPosition()
    {
        float screenWidth = mainCamera.orthographicSize * 1.2f * mainCamera.aspect;
        float screenHeight = mainCamera.orthographicSize * 1.2f;

        float randomX = 0;
        float randomY = 0;

        int side = Random.Range(0, 4);

        if (side == 0)
        {
            randomX = Random.Range(-screenWidth, screenWidth);
            randomY = screenHeight;
        }

        else if (side == 1)
        {
            randomX = Random.Range(-screenWidth, screenWidth);
            randomY = -screenHeight;
        }

        else if (side == 2)
        {
            randomX = screenWidth;
            randomY = Random.Range(-screenHeight, screenHeight);
        }

        else if (side == 3)
        {
            randomX = -screenWidth;
            randomY = Random.Range(-screenHeight, screenHeight);
        }

        Vector3 spawnPosition = new Vector3(randomX, randomY, 0f);

        return spawnPosition;
    }
}
