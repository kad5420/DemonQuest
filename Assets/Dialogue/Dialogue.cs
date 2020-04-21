using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator dialogue;
    void Start()
    {

    }

    void OnTriggerEnter()
    {
        Debug.Log("Hello world");
        dialogue.SetBool("startDialogue", true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
