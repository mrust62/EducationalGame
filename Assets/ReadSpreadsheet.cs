using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ReadSpreadsheet : MonoBehaviour
{

    public TextAsset textAssetdata;

    
    public string Text;

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


    public void Search()
    {
        string[] data = textAssetdata.text.Split(new string[] { ",", "\n" }, System.StringSplitOptions.None);

        for (int i = 0; i < data.Length; i++)
        {
            if (Text == data[i])
            {
                Name.text = data[i + 2];
                Symbol.text = data[i + 1];
            }
        }
    }

}
