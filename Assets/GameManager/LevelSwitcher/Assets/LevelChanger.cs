using Invector.vMelee;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour {

	public Animator animator;

	private int levelToLoad;
	public vMeleeManager playerMeleeManager;
	// Update is called once per frame

	void Start()
	{
		animator = GetComponent<Animator>();
	}
	void OnTriggerEnter() {
		FadeToNextLevel();
	}

	public void FadeToNextLevel ()
	{
		FadeToLevel(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void FadeToLevel (int levelIndex)
	{
		levelToLoad = levelIndex;
		animator.SetTrigger("FadeOut");
	}

	public void OnFadeComplete ()
	{
		SceneManager.LoadScene(levelToLoad);
	}
}
