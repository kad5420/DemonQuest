using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtonController : MonoBehaviour {

	Canvas menu;
	public int index;
	public bool buttonPressed = false;

	[SerializeField] bool keyDown;
	[SerializeField] int maxIndex;
	[SerializeField] Animator animator;

	public AudioSource audioSource;
	public AudioClip selectionSound;
	public AudioClip closeSound;

	bool isFaded = false;
	public float fadeDuration = .4f;

	void Start() {
		animator = GetComponent<Animator>();
		menu = GetComponent<Canvas>();
		audioSource = GetComponent<AudioSource>();
    }

	// Update is called once per frame
	void Update()
	{
        if (buttonPressed)
        {
            menuButtonPressed();
		}
		else
        {
            navigateUntilSelection();
        }
	}

	void navigateUntilSelection()
    {
		if (Input.GetAxis("Vertical") != 0)
		{
			if (!keyDown)
			{
				if (Input.GetAxis("Vertical") < 0)
				{
					if (index < maxIndex)
					{
						index++;
					}
					else
					{
						index = 0;
					}
				}
				else if (Input.GetAxis("Vertical") > 0)
				{
					if (index > 0)
					{
						index--;
					}
					else
					{
						index = maxIndex;
					}
				}
				keyDown = true;
			}
		}
		else
		{
			keyDown = false;
		}
	}


	void menuButtonPressed()
	{
        // Play Game
		if (index == 0)
        {
			audioSource.PlayOneShot(selectionSound);
			playGameButtonPressed();

		}
        // Exit Game
        else if (index == 1)
        {
			audioSource.PlayOneShot(closeSound);
			Debug.Log("Quitting Game");
			Application.Quit();
        }

	}

    void playGameButtonPressed()
    {
        // Menu is not faded by default, if you pressed play fade the menu
        if (!isFaded)
        {
			Fade(); // Code resumes at the end of DoFade.... kinda stupid but idk how to fix it rn
		}
    }

	public void Fade()
	{
		animator.SetBool("fadeOut", true);
		var canvGroup = GetComponent<CanvasGroup>();

		//Toggle the end value depending on the faded state ( from 1 to 0)
		StartCoroutine(DoFade(canvGroup, canvGroup.alpha, isFaded ? 1 : 0));

		//Toggle the faded state
		isFaded = !isFaded;
	}

	public IEnumerator DoFade(CanvasGroup canvGroup, float start, float end)//Runto complition beforex
	{
		float counter = 0f;

		while (counter < fadeDuration)
		{
			counter += Time.deltaTime;
			canvGroup.alpha = Mathf.Lerp(start, end, counter / fadeDuration);

			yield return null; //Because we don't need a return value.
		}

        if (counter >= fadeDuration)
        {
			isFaded = true;
			menu.enabled = false;
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
	}
}
