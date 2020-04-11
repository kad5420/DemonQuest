using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownUI : MonoBehaviour
{
    public Text countdownDisplay;
    public int countdownTime;

    public void Start()
    {
        countdownDisplay = transform.GetChild(0).gameObject.GetComponent<Text>();
    }

    public void startCountdown()
    {
        Debug.Log("CountdownToStart()");
        StartCoroutine(CountdownToStart());
    }

    IEnumerator CountdownToStart()
    {
        while (countdownTime > 0)
        {
            Debug.Log("Countdown time = " + countdownTime.ToString());
            countdownDisplay.text = countdownTime.ToString();
            yield return new WaitForSeconds(1f);
            countdownTime--;
        }
        countdownDisplay.gameObject.SetActive(false);
    }
}
