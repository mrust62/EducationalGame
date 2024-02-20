using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public GameObject[] Levels;

    int currentLevel;

    public void correctAnswer()
    {
        if (currentLevel + 1 != Levels.Length)
        {
            Levels[currentLevel].SetActive(false);


        }
    }


    // Start is called before the first frame update
    void Start()
    {

    }


    string clickedButton = "";
    string clickedButton2 = "";


    //Checks if the elewment matches the atomic Symbol
    public void correctMatch()
    {

        if (clickedButton == "")
        {
            clickedButton = EventSystem.current.currentSelectedGameObject.GetComponentInChildren<Text>().text;
            Debug.Log(clickedButton);
        }
        else if (clickedButton2 == "")
        {
            clickedButton2 = EventSystem.current.currentSelectedGameObject.GetComponentInChildren<Text>().text;
            Debug.Log(clickedButton2);

            if (clickedButton == "Gold" && clickedButton2 == "Au")
            {
                Debug.Log("CORRECT");
                clickedButton = "";
                clickedButton2 = "";
            }
            else if (clickedButton == "Hydrogen" && clickedButton2 == "H")
            {
                Debug.Log("CORRECT");
                clickedButton = "";
                clickedButton2 = "";
            }
            else if (clickedButton == "Titanium" && clickedButton2 == "Ti")
            {
                Debug.Log("CORRECT");
                clickedButton = "";
                clickedButton2 = "";
            }
            else if (clickedButton == "Carbon" && clickedButton2 == "C")
            {
                Debug.Log("CORRECT");
                clickedButton = "";
                clickedButton2 = "";
            }
            else
            {
                Debug.Log("INCORRECT");
                clickedButton = "";
                clickedButton2 = "";
            }


        }




    }
}
