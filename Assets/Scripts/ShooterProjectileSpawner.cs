using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterProjectileSpawner : MonoBehaviour
{
    public int startDelay;
    public int shootDelay;
    public GameObject projectilePrefab;
    public GameObject projectileSpawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnProjectile", startDelay, shootDelay);
    }

    void SpawnProjectile() {
        Instantiate(projectilePrefab, projectileSpawnPoint.transform.position, transform.rotation);
    }
}
