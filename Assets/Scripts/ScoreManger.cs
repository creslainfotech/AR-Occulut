using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI ;

public class ScoreManger : MonoBehaviour 
{
    public int d1;
    public GameObject aaa;
    public void Start()
    
    {
        
        d1 = PlayerPrefs.GetInt("ut");

        Debug.Log(d1);
      

        if (d1 == 1)
        {
            GameObject.Find("Cube").SetActive(true);
            GameObject.Find("openb").SetActive(true);
           
        }
        else if(d1 == 2)
        {
            GameObject.Find("Cube").SetActive(true);
            GameObject.Find("openb").SetActive(true);
          
        }

        else if (d1 == 3)
        {
            GameObject.Find("Cube").SetActive(true);
            GameObject.Find("openb").SetActive(true);
          
        }
        else if (d1 == 4)
        {
            GameObject.Find("Cube").SetActive(true);
            GameObject.Find("openb").SetActive(true);

        }
        else if (d1 == 5)
        {
            GameObject.Find("Cube").SetActive(true);
            GameObject.Find("openb").SetActive(true);

        }
        else if (d1 == 6)
        {
            GameObject.Find("Cube").SetActive(true);
            GameObject.Find("openb").SetActive(true);

        }
        else if (d1 == 7)
        {
            GameObject.Find("Cube").SetActive(true);
            GameObject.Find("openb").SetActive(true);

        }
        else if (d1 == 8)
        {
            GameObject.Find("Cube").SetActive(true);
            GameObject.Find("openb").SetActive(true);

        }
        else
        {
            GameObject.Find("openb").SetActive(false);
            GameObject.Find("Cube").SetActive(false);

        }
            
        
    }
}
   

