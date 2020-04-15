using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public List<Transform> spawnLocations;
    public bool spawn;

    // Uses empty-GameObjects as spawn locations

    void Start()
    {
        spawnLocations = transform.Cast<Transform>().ToList();
    }
    
    void Update()
    {
        if (spawn)
        {
            spawnEnemies();
        }
    }

    public void spawnEnemies()
    {
        foreach (Transform location in spawnLocations)
        {
            Debug.Log(location);
            Instantiate(enemyPrefab, location);
        }
        spawn = false;
    }
}
