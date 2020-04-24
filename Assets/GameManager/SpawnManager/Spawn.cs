using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Spawn : MonoBehaviour
{
    public GameObject enemy;
    public Transform[] spawnLocations;

    public void Start()
    {
        spawnLocations = GetComponentsInChildren<Transform>();
        disableMeshRenders();
    }

    void disableMeshRenders()
    {
        foreach (Transform location in spawnLocations)
        {
            location.GetComponent<MeshRenderer>().enabled = false;
        }
    }

    public void spawnEnemies(int wave)
    {
        foreach (Transform location in spawnLocations)
        {
            if (wave > 0) {
                Instantiate(enemy, location);
            }
            wave--;
        }
    }
}
