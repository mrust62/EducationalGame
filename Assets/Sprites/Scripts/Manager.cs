using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

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
        Vector3[] positionArray = new Vector3[8];
        positionArray[0] = new Vector3(Random.Range(-756, -600), Random.Range(-357, 0), 0);
        positionArray[1] = new Vector3(Random.Range(-500, -400), Random.Range(-357, 0), 0);
        positionArray[2] = new Vector3(Random.Range(-300, -200), Random.Range(-357, 0), 0);
        positionArray[3] = new Vector3(Random.Range(-100, -50), Random.Range(-357, 0), 0);
        positionArray[4] = new Vector3(Random.Range(50, 100), Random.Range(-357, 0), 0);
        positionArray[5] = new Vector3(Random.Range(200, 300), Random.Range(-357, 0), 0);
        positionArray[6] = new Vector3(Random.Range(400, 500), Random.Range(-357, 0), 0);
        positionArray[7] = new Vector3(Random.Range(600, 756), Random.Range(-357, 0), 0);

        bool[] confirmationArray = new bool[positionArray.Length];
        int randomLocation = Random.Range(0, 7);
        confirmationArray[randomLocation] = true;
        for (int i = 0; i<=7; i++)
        {
            if (i == 0)
            {
                element1.transform.localPosition = positionArray[randomLocation];
            }
            else if (i == 1)
            {
                element2.transform.localPosition = positionArray[randomLocation];
            }
            else if (i == 2)
            {
                element3.transform.localPosition = positionArray[randomLocation];
            }
            else if (i == 3)
            {
                element4.transform.localPosition = positionArray[randomLocation];
            }
            else if (i == 4)
            {
                symbol1.transform.localPosition = positionArray[randomLocation];
            }
            else if (i == 5)
            {
                symbol2.transform.localPosition = positionArray[randomLocation];
            }
            else if (i == 6)
            {
                symbol3.transform.localPosition = positionArray[randomLocation];

            }
            else if (i == 7)
            {
                symbol4.transform.localPosition = positionArray[randomLocation];
            }
            
            
            
            while (confirmationArray[randomLocation] == true && i !=7)
            {
                randomLocation = Random.Range(0, positionArray.Length);
            }
            
            confirmationArray[randomLocation] = true;
        }
         
    }


    string clickedButton = "";
    string clickedButton2 = "";

    int numbCorrect = 0;
    static int numbRounds = 0;

    //Checks if the elewment matches the atomic Symbol
    public void correctMatch()
    {
        

        if (clickedButton == "")
        {
            clickedButton = EventSystem.current.currentSelectedGameObject.name;
            
            if (clickedButton == "Element1")
            {
                element1.GetComponent<Outline>().enabled = true;
            }
            else if (clickedButton == "Element2")
            {
                element2.GetComponent<Outline>().enabled = true;
            }
            else if (clickedButton == "Element3")
            {
                element3.GetComponent<Outline>().enabled = true;
            }
            else if (clickedButton == "Element4")
            {
                element4.GetComponent<Outline>().enabled = true;
            }
            else if (clickedButton == "Symbol1")
            {
                symbol1.GetComponent<Outline>().enabled = true;
            }
            else if (clickedButton == "Symbol2")
            {
                symbol2.GetComponent<Outline>().enabled = true;
            }
            else if (clickedButton == "Symbol3")
            {
                symbol3.GetComponent<Outline>().enabled = true;
            }
            else if (clickedButton == "Symbol4")
            {
                symbol4.GetComponent<Outline>().enabled = true;
            }

        }
        else if (clickedButton2 == "")
        {
            clickedButton2 = EventSystem.current.currentSelectedGameObject.name;
            
            if (clickedButton2 == "Element1")
            {
                element1.GetComponent<Outline>().enabled = true;
            }
            else if (clickedButton2 == "Element2")
            {
                element2.GetComponent<Outline>().enabled = true;
            }
            else if (clickedButton2 == "Element3")
            {
                element3.GetComponent<Outline>().enabled = true;
            }
            else if (clickedButton2 == "Element4")
            {
                element4.GetComponent<Outline>().enabled = true;
            }
            else if (clickedButton2 == "Symbol1")
            {
                symbol1.GetComponent<Outline>().enabled = true;
            }
            else if (clickedButton2 == "Symbol2")
            {
                symbol2.GetComponent<Outline>().enabled = true;
            }
            else if (clickedButton2 == "Symbol3")
            {
                symbol3.GetComponent<Outline>().enabled = true;
            }
            else if (clickedButton2 == "Symbol4")
            {
                symbol4.GetComponent<Outline>().enabled = true;
            }



            




            if ((clickedButton == "Element1" && clickedButton2 == "Symbol1") || (clickedButton == "Symbol1" && clickedButton2 == "Element1"))
            {
                
                clickedButton = "";
                clickedButton2 = "";
                Destroy(symbol1);
                Destroy(symbol1.GetComponent<Image>());
                Destroy(element1);
                Destroy(element1.GetComponent<Image>());
                element1Text.text = "";
                symbol1Text.text = "";

                numbCorrect+=1;
                if (numbCorrect == 4)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                    numbRounds+=1;
                    numbCorrect = 0;
                    
                }
                if (numbRounds == 3)
                {
                    SceneManager.LoadSceneAsync(1);
                    numbRounds = 0;
                }

            }
            else if ((clickedButton == "Element2" && clickedButton2 == "Symbol2") || (clickedButton == "Symbol2" && clickedButton2 == "Element2"))
            {
                
                clickedButton = "";
                clickedButton2 = "";
                Destroy(symbol2);
                Destroy(symbol2.GetComponent<Image>());
                Destroy(element2);
                Destroy(element2.GetComponent<Image>());
                element2Text.text = "";
                symbol2Text.text = "";

                numbCorrect+=1;
                if (numbCorrect == 4)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                    numbRounds+=1;
                    numbCorrect = 0;
                    
                }
                if (numbRounds == 3)
                {
                    SceneManager.LoadSceneAsync(1);
                    Debug.Log("3 ROUNDS");
                    numbRounds = 0;
                }

            }
            else if ((clickedButton == "Element3" && clickedButton2 == "Symbol3") || (clickedButton == "Symbol3" && clickedButton2 == "Element3"))
            {
                
                clickedButton = "";
                clickedButton2 = "";
                Destroy(symbol3);
                Destroy(symbol3.GetComponent<Image>());
                Destroy(element3);
                Destroy(element3.GetComponent<Image>());
                element3Text.text = "";
                symbol3Text.text = "";

                numbCorrect+=1;
                if (numbCorrect == 4)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                    numbRounds+=1;
                    numbCorrect = 0;
                    
                }
                if (numbRounds == 3)
                {
                    SceneManager.LoadSceneAsync(1);
                    Debug.Log("3 ROUNDS");
                    numbRounds = 0;
                }

            }
            else if ((clickedButton == "Element4" && clickedButton2 == "Symbol4") || (clickedButton == "Symbol4" && clickedButton2 == "Element4"))
            {
                
                clickedButton = "";
                clickedButton2 = "";
                Destroy(symbol4);
                Destroy(symbol4.GetComponent<Image>());
                Destroy(element4);
                Destroy(element4.GetComponent<Image>());
                element4Text.text = "";
                symbol4Text.text = "";

                numbCorrect+=1;
                if (numbCorrect == 4)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                    numbRounds+=1;
                    numbCorrect = 0;
                    
                }
                if (numbRounds == 3)
                {
                    SceneManager.LoadSceneAsync(1);
                    Debug.Log("3 ROUNDS");
                    numbRounds = 0;
                }

            }
            else
            {
                
                if (clickedButton == "Element1" || clickedButton2 == "Element1")
                {
                    element1.GetComponent<Outline>().enabled = false;
                }
                if (clickedButton == "Element2" || clickedButton2 == "Element2")
                {
                    element2.GetComponent<Outline>().enabled = false;
                }
                if (clickedButton == "Element3" || clickedButton2 == "Element3")
                {
                    element3.GetComponent<Outline>().enabled = false;
                }
                if (clickedButton == "Element4" || clickedButton2 == "Element4")
                {
                    element4.GetComponent<Outline>().enabled = false;
                }
                if (clickedButton == "Symbol1" || clickedButton2 == "Symbol1")
                {
                    symbol1.GetComponent<Outline>().enabled = false;
                }
                if (clickedButton == "Symbol2" || clickedButton2 == "Symbol2")
                {
                    symbol2.GetComponent<Outline>().enabled = false;
                }
                if (clickedButton == "Symbol3" || clickedButton2 == "Symbol3")
                {
                    symbol3.GetComponent<Outline>().enabled = false;
                }
                if (clickedButton == "Symbol4" || clickedButton2 == "Symbol4")
                {
                    symbol4.GetComponent<Outline>().enabled = false;
                }

                clickedButton = "";
                clickedButton2 = "";
            }
            
        }

    }





}