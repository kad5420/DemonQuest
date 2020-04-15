using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    List<Transform> spawnLocations;

    // Uses empty-GameObjects as spawn locations

    void Start()
    {
        spawnLocations = transform.Cast<Transform>().ToList();
    }

    public void spawnEnemies()
    {
        foreach (Transform location in spawnLocations)
        {
            Debug.Log(location);
            Instantiate(enemyPrefab, location);
        }
    }
}
