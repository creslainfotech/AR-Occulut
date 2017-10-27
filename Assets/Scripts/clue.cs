using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clue : MonoBehaviour {
    public Text countText;
    public string displaytext;
    public int d2;

    public void cluescript()
    {
    
        d2 = PlayerPrefs.GetInt("ut");

        Debug.Log(d2);

        if (d2 == 1)
        {
            displaytext = "Home";
            countText.text = displaytext;
        }
        else if (d2 == 2)
        {
            displaytext = "BP";
            countText.text = displaytext;
        }

        else if (d2 == 3)
        {
            displaytext = "AR CAfe";
            countText.text = displaytext;
        }
        else
        {
            displaytext = "HAHAH u r not close";
            countText.text = displaytext;
        }


    }
}

