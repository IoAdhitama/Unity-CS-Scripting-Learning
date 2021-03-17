// See StaticsScene for usage of this script.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStatics : MonoBehaviour
{
    public GameObject allyPrefab;
    public GameObject enemyPrefab;

    public Text allySpawnedCount;
    public Text enemySpawnedCount;

    // Start is called before the first frame update
    void Start()
    {
        allySpawnedCount.text = "Ally Spawned: " + AllyStatics.allyCount;
        enemySpawnedCount.text = "Enemy Spawned: " + EnemyStatics.enemyCount;
    }

    // Update is called once per frame
    void Update()
    {
        // Spawn an allied (blue) unit from the left of the screen when Z is pressed
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Instantiate(allyPrefab, new Vector3(-8.5f, 1.05f, 0f), Quaternion.identity);
            AllyStatics.allyCount++;

            // Access the static variable of the class, which tracks the amount of allies spawned
            // And update the UI with that count
            allySpawnedCount.text = "Ally Spawned: " + AllyStatics.allyCount;
        }

        // Spawn an enemy (red) unit from the right of the screen when M is pressed
        if (Input.GetKeyDown(KeyCode.M))
        {
            Instantiate(enemyPrefab, new Vector3(8.5f, 1.05f, 0f), Quaternion.identity);
            EnemyStatics.enemyCount++;

            // Access the static variable of the class, which tracks the amount of allies spawned
            // And update the UI with that count
            enemySpawnedCount.text = "Enemy Spawned: " + EnemyStatics.enemyCount;
        }
    }
}
