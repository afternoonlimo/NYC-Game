using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject collectiblePrefab;
    public float spawnIntervals = 5.0f;
    public float timeSinceLastSpawn = 0f;

    // Start is called before the first frame update
    void Start()
    {

    }
    public void SpawnNewCollectible()
    {
        float randonXPos = Random.Range(-8f, 7.5f);
        float randonYPos = Random.Range(1.25f, 4.15f);
        Vector2 spawnPos = new Vector2(randonXPos, randonYPos);
        GameObject newCollectible = Instantiate(collectiblePrefab, spawnPos, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;
        if (timeSinceLastSpawn > spawnIntervals)
        {
            SpawnNewCollectible();
            timeSinceLastSpawn = 0f;
            if (timeSinceLastSpawn > 1.0f)
            {
                timeSinceLastSpawn -= 0.2f;
            }
        }


    }
}
