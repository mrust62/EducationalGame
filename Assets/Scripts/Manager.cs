using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

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

    public TextMeshProUGUI element1Text;
    public TextMeshProUGUI element2Text;
    public TextMeshProUGUI element3Text;
    public TextMeshProUGUI element4Text;
    public TextMeshProUGUI symbol1Text;
    public TextMeshProUGUI symbol2Text;
    public TextMeshProUGUI symbol3Text;
    public TextMeshProUGUI symbol4Text;

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
                clickedButton = "";
                clickedButton2 = "";
                Destroy(symbol1);
                Destroy(symbol1.GetComponent<Image>());
                Destroy(element1);
                Destroy(element1.GetComponent<Image>());
                element1Text.text = "";
                symbol1Text.text = "";
            }
            else if ((clickedButton == "Element2" && clickedButton2 == "Symbol2") || (clickedButton == "Symbol2" && clickedButton2 == "Element2"))
            {
                Debug.Log("CORRECT");
                clickedButton = "";
                clickedButton2 = "";
                Destroy(symbol2);
                Destroy(symbol2.GetComponent<Image>());
                Destroy(element2);
                Destroy(element2.GetComponent<Image>());
                element2Text.text = "";
                symbol2Text.text = "";
            }
            else if ((clickedButton == "Element3" && clickedButton2 == "Symbol3") || (clickedButton == "Symbol3" && clickedButton2 == "Element3"))
            {
                Debug.Log("CORRECT");
                clickedButton = "";
                clickedButton2 = "";
                Destroy(symbol3);
                Destroy(symbol3.GetComponent<Image>());
                Destroy(element3);
                Destroy(element3.GetComponent<Image>());
                element3Text.text = "";
                symbol3Text.text = "";

            }
            else if ((clickedButton == "Element4" && clickedButton2 == "Symbol4") || (clickedButton == "Symbol4" && clickedButton2 == "Element4"))
            {
                Debug.Log("CORRECT");
                clickedButton = "";
                clickedButton2 = "";
                Destroy(symbol4);
                Destroy(symbol4.GetComponent<Image>());
                Destroy(element4);
                Destroy(element4.GetComponent<Image>());
                element4Text.text = "";
                symbol4Text.text = "";
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