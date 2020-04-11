using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArchGates : MonoBehaviour
{
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }


    public void playOpenGateAnimation()
    {
        anim.SetBool("openGates", true);
    }
}