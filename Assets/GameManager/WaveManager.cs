using System.Collections;
using System.Collections.Generic;
using Invector.vCharacterController;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;



public class WaveManager : MonoBehaviour
{
    SpawnManager spawnManager;
    GameObject lightning;
    GameObject cathedralLights;
    AudioSource audio;
    public AudioClip lightningSounds;

    public vThirdPersonController playerController;

    public int currentWave = 1;

    public bool startWave = true;
    public float skyboxDark;
    public float skyboxNormal;

    void Start()
    {
        spawnManager = this.gameObject.transform.GetChild(0).GetComponent<SpawnManager>();
        lightning = this.gameObject.transform.GetChild(1).gameObject;
        cathedralLights = this.gameObject.transform.GetChild(2).gameObject;
        audio = GetComponent<AudioSource>();

    }

    void Update()
    {
        if (startWave)
        {
            beginWave();
        }
    }


    void beginWave()
    {
        // Dim Skybox
        RenderSettings.skybox.SetFloat("_Exposure", skyboxDark);

        // Start Lightning
        audio.PlayOneShot(lightningSounds);
        lightning.SetActive(true);

        // Enable Cathedral Lights
        cathedralLights.SetActive(true);

        // Spawn Enemies
        spawnManager.spawnEnemyWave(currentWave);

        StartCoroutine(waitToDisable());

        startWave = false;
        currentWave++;
    }

    IEnumerator waitToDisable()
    {
        // wait a little bit
        yield return new WaitForSeconds(6);

        //Reset Player Health
        playerController.ResetHealth();

        // Reset Skybox
        RenderSettings.skybox.SetFloat("_Exposure", skyboxNormal);

        // Disable lightning
        lightning.SetActive(false);

        // Disable Cathedral Lights
        cathedralLights.SetActive(false);
    }

}
