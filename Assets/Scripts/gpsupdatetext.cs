using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gpsupdatetext : MonoBehaviour {
    public Text coordinates1; //text for testing lan
    public Text coordinates2; // text for testing long
    public Text coordinates3; // text for testing output 
    public Text moretogo;
    public float a,a4, a5,a6,a7,a8; //user lat 
    public float b; //user long
    public float c; //copy of a
    public int d;
    public string displaytext;
    public float Ula1,tla1, tla2, tla3, tla4, tla5, tla6, tla7,tla8; // target lat 1,2,3
    public float Ulo1,tlo1, tlo2, tlo3, tlo4, tlo5, tlo6, tlo7, tlo8;// target long 1,2,3
    public string moretogotext = "8";
    void Update()
    {
        coordinates1.text = "lat: " + Gps.Instance.latitude.ToString();
        coordinates2.text = "long: " + Gps.Instance.longitude.ToString();
        Ula1 = Gps.Instance.latitude; // user lat
        Ulo1 = Gps.Instance.longitude; // user lon
        tla1 = 12.97278f; //location 1 clg
        tlo1 = 77.61281f;
        tla2 = 12.97020f; //location 2 Garuda mall
        tlo2 = 77.61012f;
        tla3 = 12.97768f; //location 3 Chinnaswami stadium
        tlo3 = 77.59899f;
        tla4 = 12.97415f; //location 4 state central library
        tlo4 = 77.59056f;
        tla5 = 12.98430f; //location 5 st basicllica
        tlo5 = 77.60497f;
        tla6 = 12.97102f; //location 6 lamborgini
        tlo6 = 77.59806f;
        tla7 = 12.97460f; //location 7 one plus 
        tlo7 = 77.60778f;
        tla8 = 12.97335f; //location 8 one mg mall
        tlo8 = 77.62025f;


        a = Checkforlocation(Ula1, Ulo1, tla1, tlo1);
        if (a == 1)
        {
            d = 1;
            PlayerPrefs.SetInt("ut", d);
            displaytext = "SJIM";
            coordinates3.text = displaytext;
            moretogotext = "8";
        }
        else
        {
            b = Checkforlocation(Ula1, Ulo1, tla2, tlo2);
            if (b == 1)
            {
                d = 2;
                PlayerPrefs.SetInt("ut", d);
                displaytext = "Gmall";
                coordinates3.text = displaytext;
                moretogotext = "7";
            }
            else
            {
                c = Checkforlocation(Ula1, Ulo1, tla3, tlo3);
                if (c == 1)
                {
                    d = 3;
                    PlayerPrefs.SetInt("ut", d);
                    displaytext = "CS";
                    coordinates3.text = displaytext;
                    moretogotext = "6";
                }

                else
                {
                    a4 = Checkforlocation(Ula1, Ulo1, tla4, tlo4);
                    if (a4 == 1)
                    {
                        d = 4;
                        PlayerPrefs.SetInt("ut", d);
                        displaytext = "SCL";
                        coordinates3.text = displaytext;
                        moretogotext = "5";
                    }

                    else
                    {
                        a5 = Checkforlocation(Ula1, Ulo1, tla5, tlo5);
                        if (a5 == 1)
                        {
                            d = 5;
                            PlayerPrefs.SetInt("ut", d);
                            displaytext = "St.Bacl";
                            coordinates3.text = displaytext;
                            moretogotext = "4";
                        }

                        else
                        {
                            a6 = Checkforlocation(Ula1, Ulo1, tla6, tlo6);
                            if (a6 == 1)
                            {
                                d = 6;
                                PlayerPrefs.SetInt("ut", d);
                                displaytext = "Lamp";
                                coordinates3.text = displaytext;
                                moretogotext = "3";
                            }


                            else
                            {
                                a7 = Checkforlocation(Ula1, Ulo1, tla7, tlo7);
                                if (a7 == 1)
                                {
                                    d = 7;
                                    PlayerPrefs.SetInt("ut", d);
                                    displaytext = "One +1";
                                    coordinates3.text = displaytext;
                                    moretogotext = "2";
                                }

                                else
                                {
                                    a8 = Checkforlocation(Ula1, Ulo1, tla8, tlo8);
                                    if (a8 == 1)
                                    {
                                        d = 8;
                                        PlayerPrefs.SetInt("ut", d);
                                        displaytext = "1mg";
                                        coordinates3.text = displaytext;
                                        moretogotext = "1";
                                    }

                                    else
                                    {
                                        d = 0;
                                        PlayerPrefs.SetInt("ut", d);
                                        displaytext = "SEEK";
                                        coordinates3.text = displaytext;
                                    }

                                }
                            }
                        }
                    }
                }
            }
        }
        Debug.Log("d" + d);
        moretogo.text = moretogotext;


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
            
        if (e < 30)
            {
            return 1;
        }
            else
            {
             return 0;
            }
        }
}
