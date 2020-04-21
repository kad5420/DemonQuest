using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class openGate : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator anim;
    public Invector.vMelee.vMeleeManager meleeManager;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((meleeManager.leftWeapon != null) && (meleeManager.rightWeapon != null))
        {
            Debug.Log("Opening Gate!!!");
            anim.SetBool("openGate", true);
        }
    }
}
