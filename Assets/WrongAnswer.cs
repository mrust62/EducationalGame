using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class WrongAnswer : MonoBehaviour
{

    public Button wrongAnswer1;
    public Button wrongAnswer2;
    public Button wrongAnswer3;


    string clickedButton = "";

    public void highlightWrong()
    {
        
        if (clickedButton == "")
        {
            clickedButton = EventSystem.current.currentSelectedGameObject.name;

            if (clickedButton == "option2Button")
            {
                wrongAnswer1.GetComponent<Image>().color = Color.red;
                clickedButton = "";
            }
            else if (clickedButton == "option3Button")
            {
                wrongAnswer2.GetComponent<Image>().color = Color.red;
                clickedButton = "";
            } 
            else if (clickedButton == "option4Button")
            {
                wrongAnswer3.GetComponent<Image>().color = Color.red;
                clickedButton = "";
            }
            else
            {
                clickedButton = "";
            }
        }
        
    }

}
