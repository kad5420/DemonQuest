using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class GameManager : MonoBehaviour
{
    SpawnManager spawnManager; // Must be first child
    Animator archGates;        // Must be second child
    CountdownUI countdownUI;   // Must be third child

    public bool spawn = false;

    void Start()
    {
        spawnManager = transform.GetChild(0).gameObject.GetComponent<SpawnManager>();
        archGates    = transform.GetChild(1).gameObject.GetComponent<ArchGates>().GetComponent<Animator>();
        countdownUI  = transform.GetChild(2).gameObject.GetComponent<CountdownUI>();
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
        countdownUI.startCountdown();
        spawnManager.spawnEnemies();
        archGates.SetBool("openGates", true);
        spawn = false;
    }

    void endWave()
    {

    }


}

//  should be some UI that counts down and then the enemies should spawn, the gates open