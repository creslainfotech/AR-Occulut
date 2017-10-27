using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gpsupdatetext : MonoBehaviour {
    public static gpsupdatetext Instance1 { set; get; }
    public Text coordinates1; //text for testing lan
    public Text coordinates2; // text for testing long
    public Text coordinates3; // text for testing output 
    public float a; //user lat 
    public float b; //user long
    public float c; //copy of a
    public int d;
    public string displaytext;
    public float Ula1,tla1, tla2, tla3; // target lat 1,2,3
    public float Ulo1,tlo1, tlo2, tlo3;// target long 1,2,3

    void Start()
    {

        Instance1 = this;
        DontDestroyOnLoad(gameObject);

    }
    void Update()
    {
        coordinates1.text = "lat: " + Gps.Instance.latitude.ToString();
        coordinates2.text = "long: " + Gps.Instance.longitude.ToString();
        Ula1 = Gps.Instance.latitude; // user lat
        Ulo1 = Gps.Instance.longitude; // user lon
        tla1 = 12.93317f; //location 1
        tlo1 = 77.60825f;
        tla2 = 12.93325f; //location 2
        tlo2 = 77.60735f;
        tla3 = 12.93132f; //location 3
        tlo3 = 77.60734f;

                      
        a=Checkforlocation(Ula1, Ulo1, tla1, tlo1);
        if(a==1)
        {
            d = 1;
            PlayerPrefs.SetInt("ut", d);
            displaytext  = "Home";
            coordinates3.text = displaytext;
        }
        else
        {
            b = Checkforlocation(Ula1, Ulo1, tla2, tlo2);
            if (b == 1)
            {
                d = 2;
                PlayerPrefs.SetInt("ut", d);
                displaytext = "BP";
                coordinates3.text = displaytext;
            }
            else
            {
                c = Checkforlocation(Ula1, Ulo1, tla3, tlo3);
                if (c == 1)
                {
                    d = 3;
                    PlayerPrefs.SetInt("ut", d);
                    displaytext = "AR Cafe";
                    coordinates3.text = displaytext;
                }
                else
                {
                    d = 0;
                    PlayerPrefs.SetInt("ut", d);
                    displaytext = "HAHAH u r not close";
                    coordinates3.text = displaytext;
                }
            }
        }
        Debug.Log("d"+d);
       
    }
        int Checkforlocation(float la2, float lo2,float la1, float lo1)
        {
            var R = 6371e3;
            var dlon = Mathf.Abs(lo2 * Mathf.Deg2Rad - lo1 * Mathf.Deg2Rad);
            var dlat = Mathf.Abs(la2 * Mathf.Deg2Rad - la1 * Mathf.Deg2Rad);
            var a1 = Mathf.Pow((Mathf.Sin(dlat / 2)), 2) + Mathf.Cos(Mathf.Deg2Rad * la1) * Mathf.Cos(Mathf.Deg2Rad * la2) * Mathf.Pow((Mathf.Sin(dlon / 2)), 2);
            var c1 = 2 * Mathf.Atan2(Mathf.Sqrt(a1), Mathf.Sqrt(1 - a1));
            var d1 = R * c1;//(where R is the radius of the Earth)
            int e = (int)d1;
            if (e < 20)
            {
            return 1;
            }
            else
            {
            return 0;
            }
        }
    
      

    
}
