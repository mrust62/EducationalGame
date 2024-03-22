using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public GameObject[] Levels;

    int currentLevel;

    public Button element1;
    public Button symbol1;
    public Button element2;
    public Button symbol2;
    public Button element3;
    public Button symbol3;
    public Button element4;
    public Button symbol4;

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
        element1.transform.localPosition = new Vector3(Random.Range(-822, 822), Random.Range(-484, 0), 0);
        element2.transform.localPosition = new Vector3(Random.Range(-822, 822), Random.Range(-484, 0), 0);
        element3.transform.localPosition = new Vector3(Random.Range(-822, 822), Random.Range(-484, 0), 0);
        element4.transform.localPosition = new Vector3(Random.Range(-822, 822), Random.Range(-484, 0), 0);
        symbol1.transform.localPosition = new Vector3(Random.Range(-822, 822), Random.Range(-484, 0), 0);
        symbol2.transform.localPosition = new Vector3(Random.Range(-822, 822), Random.Range(-484, 0), 0);
        symbol3.transform.localPosition = new Vector3(Random.Range(-822, 822), Random.Range(-484, 0), 0);
        symbol4.transform.localPosition = new Vector3(Random.Range(-822, 822), Random.Range(-484, 0), 0);
    }


    string clickedButton = "";
    string clickedButton2 = "";
    

    //Checks if the elewment matches the atomic Symbol
    public void correctMatch()
    {

        if (clickedButton == "")
        {
            clickedButton = EventSystem.current.currentSelectedGameObject.name;
            Debug.Log(clickedButton);
        }
        else if (clickedButton2 == "")
        {
            clickedButton2 = EventSystem.current.currentSelectedGameObject.name;
            Debug.Log(clickedButton2);

            if ((clickedButton == "Element1" && clickedButton2 == "Symbol1") || (clickedButton == "Symbol1" && clickedButton2 == "Element1"))
            {
                Debug.Log("CORRECT");
                element1.GetComponent<Image>().color = new Color(0, 255, 0);
                symbol1.GetComponent<Image>().color = new Color(0, 255, 0);
                clickedButton = "";
                clickedButton2 = "";
            }
            else if ((clickedButton == "Element2" && clickedButton2 == "Symbol2") || (clickedButton == "Symbol2" && clickedButton2 == "Element2"))
            {
                element2.GetComponent<Image>().color = new Color(0, 255, 0);
                symbol2.GetComponent<Image>().color = new Color(0, 255, 0);
                Debug.Log("CORRECT");
                clickedButton = "";
                clickedButton2 = "";
            }
            else if ((clickedButton == "Element3" && clickedButton2 == "Symbol3") || (clickedButton == "Symbol3" && clickedButton2 == "Element3"))
            {
                element3.GetComponent<Image>().color = new Color(0, 255, 0);
                symbol3.GetComponent<Image>().color = new Color(0, 255, 0);
                Debug.Log("CORRECT");
                clickedButton = "";
                clickedButton2 = "";
            }
            else if ((clickedButton == "Element4" && clickedButton2 == "Symbol4") || (clickedButton == "Symbol4" && clickedButton2 == "Element4"))
            {
                element4.GetComponent<Image>().color = new Color(0, 255, 0);
                symbol4.GetComponent<Image>().color = new Color(0, 255, 0);
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
