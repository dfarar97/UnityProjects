using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnIntervalLower = 3.0f;
    private float spawnIntervalUpper = 5.0f;
    private float spawnDelay;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnRandomBall", startDelay);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        spawnDelay = Random.Range(spawnIntervalLower, spawnIntervalUpper);
        
       // Debug.Log(spawnDelay);
        int ballIndex = Random.Range(0, ballPrefabs.Length - 1); // counts 0-2. Three is the upper bound 

        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);

        Invoke("SpawnRandomBall", spawnDelay);
    }

}
