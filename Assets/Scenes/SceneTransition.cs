using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{

	public Animator animator;

	private int levelToLoad;

	void OnCollisionEnter()
	{
		Debug.Log("Move_To_Scene");
		FadeToNextLevel();
	}


	public void FadeToNextLevel()
	{
		FadeToLevel(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void FadeToLevel(int levelIndex)
	{
		levelToLoad = levelIndex;
		animator.SetTrigger("FadeOut");
	}

	public void OnFadeComplete()
	{
		SceneManager.LoadScene(levelToLoad);
	}





}
