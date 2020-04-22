using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorFunctions : MonoBehaviour
{
	[SerializeField] MenuButtonController menuButtonController;
	public AudioClip menuSound;
	public bool disableOnce;

	void PlaySound()
	{
		if(!disableOnce){
			menuButtonController.audioSource.PlayOneShot (menuSound);
		}else{
			disableOnce = false;
		}
	}
}	
