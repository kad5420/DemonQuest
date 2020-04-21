using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator dialogue;
    public Invector.vMelee.vMeleeManager meleeManager;
    void Start()
    {

    }

    void OnTriggerEnter()
    {
        if ((meleeManager.leftWeapon == null) && (meleeManager.rightWeapon == null))
        {
            Debug.Log("Starting Dialogue");
            dialogue.SetTrigger("startDialogue");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
