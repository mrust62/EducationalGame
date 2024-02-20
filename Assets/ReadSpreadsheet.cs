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
            if (i == random1)
            {
                Debug.Log(random1);
            } 
            else if (i == random2)
            {
                Debug.Log(random2);
                
            } 
            else if (i == random3)
            {
                Debug.Log(random3);
            }
            else if (i == random4)
            {
                Debug.Log(random4);
            }
        }


    }

}
