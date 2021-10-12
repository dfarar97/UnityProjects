using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject wallPrefab;
    private float startDelay = 2;
    private float repeatRate = 2;
    private float spawnRangeLower = 4;
    private float spawnRangeUpper = 8;
    private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnWall", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnWall()
    {
        Instantiate(wallPrefab, GenerateSpawnPosition(), wallPrefab.transform.rotation);
    }

    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosY = Random.Range(spawnRangeLower, spawnRangeUpper);
        

        Vector3 randomPos = new Vector3(15, spawnPosY, 0);

        return randomPos;
    }
}
