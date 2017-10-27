using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI ;

public class ScoreManger : MonoBehaviour 
{
    public int d1;
    public GameObject aaa;
    public void Update()
    
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
        else
        {
            GameObject.Find("Cube").SetActive(false);
            GameObject.Find("openb").SetActive(false);
         
        }
            
        
    }
}
   

