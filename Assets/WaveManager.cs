using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    // Start is called before the first frame update
    SpawnManager spawnManager;
    public bool startWave = false;
    public int currentWave = 1;
    void Start()
    {
        spawnManager = this.gameObject.transform.GetChild(0).GetComponent<SpawnManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (startWave)
        {
            spawnManager.spawnEnemyWave(currentWave);
        }
        startWave = false;
    }
}
