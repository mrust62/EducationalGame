using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Geoquizreader : MonoBehaviour
{


    public TextAsset textAssetdata;

    public TextMeshProUGUI question;
    public TextMeshProUGUI correctOption;
    public TextMeshProUGUI option2;
    public TextMeshProUGUI option3;
    public TextMeshProUGUI option4;

    public Button correctAnswer;
    public Button answer2;
    public Button answer3;
    public Button answer4;

    // Start is called before the first frame update
    void Start()
    {
        getInfo();

        Vector3[] positionArray = new Vector3[4];
        positionArray[0] = new Vector3(Random.Range(-756, -400), Random.Range(-357, 150), 0);
        positionArray[1] = new Vector3(Random.Range(-300, -50), Random.Range(-357, 150), 0);
        positionArray[2] = new Vector3(Random.Range(50, 300), Random.Range(-357, 0), 0);
        positionArray[3] = new Vector3(Random.Range(400, 756), Random.Range(-357, 0), 0);


        bool[] confirmationArray = new bool[positionArray.Length];
        int randomLocation = Random.Range(0, 3);
        confirmationArray[randomLocation] = true;
        for (int i = 0; i <= 3; i++)
        {
            if (i == 0)
            {
                correctAnswer.transform.localPosition = positionArray[randomLocation];
            }
            else if (i == 1)
            {
                answer2.transform.localPosition = positionArray[randomLocation];
            }
            else if (i == 2)
            {
                answer3.transform.localPosition = positionArray[randomLocation];
            }
            else if (i == 3)
            {
                answer4.transform.localPosition = positionArray[randomLocation];
            }


            while (confirmationArray[randomLocation] == true && i != 3)
            {
                randomLocation = Random.Range(0, positionArray.Length);
            }

            confirmationArray[randomLocation] = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void getInfo()
    {
        string[] data = textAssetdata.text.Split(new string[] { ",", "\n" }, System.StringSplitOptions.None);
        Debug.Log("READ THE SPREADSHEET");

        int random1 = Random.Range(1, 1495);
        Debug.Log("RANDOM NUMBER MADE");
        while (random1 % 5 != 0)
        {
            random1 = Random.Range(1, 1495);
        }

        Debug.Log(random1 + " " + data.GetValue(random1 + 2) + " " + data.GetValue(random1 + 1) + " " + data.GetValue(random1 + 3));
        question.text = data.GetValue(random1).ToString();
        correctOption.text = data.GetValue(random1 + 1).ToString();
        option2.text = data.GetValue(random1 + 2).ToString();
        option3.text = data.GetValue(random1 + 3).ToString();
        option4.text = data.GetValue(random1 + 4).ToString();

    }

    public void checkAnswer()
    {
        Debug.Log("CORRECT");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
