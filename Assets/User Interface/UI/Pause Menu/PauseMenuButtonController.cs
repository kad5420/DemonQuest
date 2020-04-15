using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuButtonController : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool GamePaused = false;
    public GameObject pauseMenuUI;

    Canvas menu;
    public int index;
    public bool buttonPressed = false;

    [SerializeField] bool keyDown;
    [SerializeField] int maxIndex;
    [SerializeField] Animator animator;

    public AudioSource audioSource;


    void Start()
    {
        animator = GetComponent<Animator>();
		menu = GetComponent<Canvas>();
		audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        toggleMenu();
        navigateUntilSelection();

    }

    void toggleMenu()
    {
        if (Input.GetButtonDown("Start"))
        {
            if (GamePaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
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
            someButtonPressed();

        }
        // Exit Game
        else if (index == 3)
        {
            Debug.Log("Quitting Game");
            Application.Quit();
        }

    }

    void someButtonPressed()
    {

    }


    void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GamePaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0;
        GamePaused = true;
    }


}
