using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update

    public Spawn[] spawns;

    void Start()
    {
        spawns = GetComponentsInChildren<Spawn>();
    }

    public void spawnEnemyWave(int wave)
    {
        foreach (Spawn spawn in spawns)
        {
            spawn.spawnEnemies(wave);
        }
    }
}
