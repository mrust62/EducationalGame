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
    public TextMeshProUGUI Number1;
    public TextMeshProUGUI Number2;
    public TextMeshProUGUI Number3;
    public TextMeshProUGUI Number4;
    public TextMeshProUGUI Mass1;
    public TextMeshProUGUI Mass2;
    public TextMeshProUGUI Mass3;
    public TextMeshProUGUI Mass4;

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

        //randomize the elements chosen
        int random1 = Random.Range(1, 118);
        int random2 = Random.Range(1, 118);
        int random3 = Random.Range(1, 118);
        int random4 = Random.Range(1, 118);
        
        //to prevent duplicate numbers/elements from appearing
        while (random1 == random2 || random1 == random3 || random1 == random4 || random2 == random3 || random2 == random4 || random3 == random4)
        {
            random1 = Random.Range(1, 118);
            random2 = Random.Range(1, 118);
            random3 = Random.Range(1, 118);
            random4 = Random.Range(1, 118);
            
        }

        //sets the buttons and text to the correct values
        for (int i = 0; i < data.Length; i+=5)
        {
            if (data.GetValue(i).Equals(random1.ToString()))
            {
                
                Name1.text = data.GetValue(i + 2).ToString();
                Symbol1.text = data.GetValue(i + 1).ToString();
                Number1.text = data.GetValue(i).ToString();
                Mass1.text = data.GetValue(i + 3).ToString();
            } 
            else if (data.GetValue(i).Equals(random2.ToString()))
            {
                
                Name2.text = data.GetValue(i + 2).ToString();
                Symbol2.text = data.GetValue(i + 1).ToString();
                Number2.text = data.GetValue(i).ToString();
                Mass2.text = data.GetValue(i + 3).ToString();
            } 
            else if (data.GetValue(i).Equals(random3.ToString()))
            {
                
                Name3.text = data.GetValue(i + 2).ToString();
                Symbol3.text = data.GetValue(i + 1).ToString();
                Number3.text = data.GetValue(i).ToString();
                Mass3.text = data.GetValue(i + 3).ToString();
            }
            else if (data.GetValue(i).Equals(random4.ToString()))
            {
                
                Name4.text = data.GetValue(i + 2).ToString();
                Symbol4.text = data.GetValue(i + 1).ToString();
                Number4.text = data.GetValue(i).ToString();
                Mass4.text = data.GetValue(i + 3).ToString();
            }
        }

    }

}
