using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class GameManager : MonoBehaviour
{

    SpawnManager spawnManager;
    Animator archGates;

    public bool spawn = false;
    // Start is called before the first frame update
    void Start()
    {
        spawnManager = transform.GetChild(0).gameObject.GetComponent<SpawnManager>();
        archGates    = transform.GetChild(1).gameObject.GetComponent<ArchGates>().GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (spawn == true)
        {
            startWave();
        }
    }

    void startWave()
    {
        spawnManager.spawnEnemies();
        archGates.SetBool("openGates", true);
    }

    void endWave()
    {

    }


}
