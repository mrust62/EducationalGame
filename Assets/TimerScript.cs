using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{

    public static float timeLeft = 300;
    public bool timerOn = false;
    public bool resetScore = false;

    public TextMeshProUGUI timerText;
    public GameObject Planet; 
    public GameObject Victory;



    // Start is called before the first frame update
    void Start()
    {
        timerOn = true;
        resetScore = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerOn)
        {
            if(timeLeft > 0)
            {
                timeLeft -= Time.deltaTime;
                updateTimer(timeLeft);
            }
            else
            {
                Debug.Log("Time is up");
                timeLeft = 300;
                timerOn = false;
                
                Planet.SetActive(false);
                Victory.SetActive(true);
                resetScore = true;
                
            }
        }
    }

    void updateTimer(float currentTime)
    {
        currentTime += 1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        timerText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
}
