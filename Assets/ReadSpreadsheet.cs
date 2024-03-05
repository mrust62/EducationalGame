using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class ReadSpreadsheet : MonoBehaviour
{

    public TextAsset textAssetdata;

    public TextMeshProUGUI Name1;
    public TextMeshProUGUI Name2;
    public TextMeshProUGUI Name3;
    public TextMeshProUGUI Name4;
    public TextMeshProUGUI Symbol1;
    public TextMeshProUGUI Symbol2;
    public TextMeshProUGUI Symbol3;
    public TextMeshProUGUI Symbol4;

    // Start is called before the first frame update
    void Start()
    {
        getElements();
    }

    // Update is called once per frame
    void Update()
    {
        
    
    }
    

    public void getElements()
    {
        string[] data = textAssetdata.text.Split(new string[] { ",", "\n" }, System.StringSplitOptions.None);

        int random1 = Random.Range(1, 118);
        int random2 = Random.Range(1, 118);
        int random3 = Random.Range(1, 118);
        int random4 = Random.Range(1, 118);

       
        for (int i = 0; i < data.Length; i+=5)
        {
            if (data.GetValue(i).Equals(random1.ToString()))
            {
                Debug.Log(random1 + " " + data.GetValue(i + 2) + " " + data.GetValue(i + 1) + " " + data.GetValue(i + 3));
                Name1.text = data.GetValue(i + 2).ToString();
                Symbol1.text = data.GetValue(i + 1).ToString();
            } 
            else if (data.GetValue(i).Equals(random2.ToString()))
            {
                Debug.Log(random2 + " " + data.GetValue(i + 2) + " " + data.GetValue(i + 1) + " " + data.GetValue(i + 3));
                Name2.text = data.GetValue(i + 2).ToString();
                Symbol2.text = data.GetValue(i + 1).ToString();
            } 
            else if (data.GetValue(i).Equals(random3.ToString()))
            {
                Debug.Log(random3 + " " + data.GetValue(i + 2) + " " + data.GetValue(i + 1) + " " + data.GetValue(i + 3));
                Name3.text = data.GetValue(i + 2).ToString();
                Symbol3.text = data.GetValue(i + 1).ToString();
            }
            else if (data.GetValue(i).Equals(random4.ToString()))
            {
                Debug.Log(random4 + " " + data.GetValue(i + 2) + " " + data.GetValue(i + 1) + " " + data.GetValue(i + 3));
                Name4.text = data.GetValue(i + 2).ToString();
                Symbol4.text = data.GetValue(i + 1).ToString();
            }
        }


    }

}
