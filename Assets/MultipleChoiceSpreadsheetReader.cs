using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MultipleChoiceSpreadsheetReader : MonoBehaviour
{


    public TextAsset textAssetdata;

    public TextMeshProUGUI question;
    public TextMeshProUGUI correctOption;
    public TextMeshProUGUI option2;
    public TextMeshProUGUI option3;
    public TextMeshProUGUI option4;
    public TextMeshProUGUI score;
    public TextMeshProUGUI scorevictory;

    public Button correctAnswer;
    public Button answer2;
    public Button answer3;
    public Button answer4;

    
    TimerScript timerScript;

    static int numbCorrect = 0;

    // Start is called before the first frame update
    void Start()
    {
        getInfo();
        score.text = numbCorrect.ToString();
        scorevictory.text = numbCorrect.ToString();

        Vector3[] positionArray = new Vector3[4];
        positionArray[0] = new Vector3(Random.Range(-756, -500), Random.Range(-300, 150), 0);
        positionArray[1] = new Vector3(Random.Range(-300, -150), Random.Range(-300, 150), 0);
        positionArray[2] = new Vector3(Random.Range(150, 300), Random.Range(-300, 0), 0);
        positionArray[3] = new Vector3(Random.Range(500, 756), Random.Range(-300, 0), 0);


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
        timerScript = GetComponent<TimerScript>();
        
        if (timerScript.resetScore)
        {
            numbCorrect = 0;
        }
    }


    public void getInfo()
    {
        string[] data = textAssetdata.text.Split(new string[] { ",", "\n" }, System.StringSplitOptions.None);
        

        int random1 = Random.Range(1, 280);
        
        while (random1 % 5 != 0)
        {
            random1 = Random.Range(5, 280);
        }

        
        question.text = data.GetValue(random1).ToString();
        correctOption.text = data.GetValue(random1 + 1).ToString();
        option2.text = data.GetValue(random1 + 2).ToString();
        option3.text = data.GetValue(random1 + 3).ToString();
        option4.text = data.GetValue(random1 + 4).ToString();

    }

    

    public void checkAnswer()
    {
        numbCorrect += 1;
        Debug.Log("CORRECT: " + numbCorrect);
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }

    
}
