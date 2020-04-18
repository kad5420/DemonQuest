using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemy;
    public Transform[] spawnLocations;
    public bool spawn;

    public void Start()
    {
        spawnLocations = GetComponentsInChildren<Transform>();
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
            Instantiate(enemy, location);
        }
        spawn = false;
    }
}
