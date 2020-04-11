using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    // Start is called before the first frame update
    List<Transform> spawnLocations;

    void Start()
    {
        spawnLocations = transform.Cast<Transform>().ToList();
        spawnEnemies();
    }

    // Update is called once per frame
    void Update()
    {
        
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
