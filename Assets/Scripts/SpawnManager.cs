using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] prefabs;
    public int spawnRangeX;
    public int spawnRangeZ;
    public int startDelay;
    public int repeatDelay;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", startDelay, repeatDelay);
    }

    void SpawnRandomEnemy() {
        int randomIndex = Random.Range(0, prefabs.Length);
        int randomX = Random.Range(-spawnRangeX, spawnRangeX);
        int randomZ = Random.Range(-spawnRangeZ, spawnRangeZ);
        Instantiate(prefabs[randomIndex], new Vector3(randomX, 0.5f, randomZ), transform.rotation);
    }
}
