using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class ReadSpreadsheet : MonoBehaviour
{

    public TextAsset textAssetdata;

    public TextMeshProUGUI Name;
    public TextMeshProUGUI Symbol;

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

        //int random = Random.Range(1, 118);

       
        for (int i = 0; i < data.Length; i++)
        {
            if (data.GetValue(i).Equals(random1.ToString()))
            {
                Debug.Log(random1 + " " + data.GetValue(i + 2));
            } 
            else if (data.GetValue(i).Equals(random2.ToString()))
            {
                Debug.Log(random2 + " " + data.GetValue(i + 2));
                
            } 
            else if (data.GetValue(i).Equals(random3.ToString()))
            {
                Debug.Log(random3 + " " + data.GetValue(i + 2));
            }
            else if (data.GetValue(i).Equals(random4.ToString()))
            {
                Debug.Log(random4 + " " + data.GetValue(i + 2));
            }
        }


    }

}
