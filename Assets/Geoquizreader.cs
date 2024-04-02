using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Geoquizreader : MonoBehaviour
{


    public TextAsset textAssetdata;

    public TextMeshProUGUI question;
    public TextMeshProUGUI correctOption;
    public TextMeshProUGUI option2;
    public TextMeshProUGUI option3;
    public TextMeshProUGUI option4;


    // Start is called before the first frame update
    void Start()
    {
        getInfo();
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

        /*
        for (int i = 0; i < data.Length; i++)
        {
            
            if (i == random1)
            {
                Debug.Log(random1 + " " + data.GetValue(i + 2) + " " + data.GetValue(i + 1) + " " + data.GetValue(i + 3));
                question.text = data.GetValue(i).ToString();
                correctOption.text = data.GetValue(i + 1).ToString();
                option2.text = data.GetValue(i + 2).ToString();
                option3.text = data.GetValue(i + 3).ToString();
                option4.text = data.GetValue(i + 4).ToString();
            }
            
            
        }
        */
    }
}
