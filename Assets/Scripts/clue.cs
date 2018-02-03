using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clue : MonoBehaviour {
    public Text countText;
    public Text count1;
    public string displaytext;
    public string displaycount;
    public int d2;

    void Start()
    {
        Updatea();
    }
    public void Updatea()
    {
    
        d2 = PlayerPrefs.GetInt("ut");

        Debug.Log(d2);
        if (d2 == 1)
        {
            displaytext = "Constellation Aquila \n \n \n (Seek the oldest indian language; \n could help you !)";
            countText.text = displaytext;
            displaycount = "Clue 01";
            count1.text = displaycount;
        }
        else if (d2 == 2)
        {
            displaytext = " https://youtu.be/s7b0DC1KQeI \n \n “There is force within which gives you life seek that, \n in your body lies a priceless gem seek that, \n O wandering soul if you want to find the greatest treasure don’t look outside \n look inside, and seek that \n \n log10”";
            countText.text = displaytext;
            displaycount = "Clue 02";
            count1.text = displaycount;
        }

        else if (d2 == 3)
        {
            displaytext = "Before google, we actually had to physically look things up in this building full of knowledge \n \n \n I attract passers-by with my imposing structure in Pompeian red amid the greenery of landmark 'lung' area of the Bengaluru city";
            countText.text = displaytext;
            displaycount = "Clue 03";
            count1.text = displaycount;
        }
        else if (d2 == 4)
        {
            displaytext = "07|13|01|16 \n 16|21|12|19|05 \n 03|15|04|05 \n \n \n 7J4VXJM3+PX";
            countText.text = displaytext;
            displaycount = "Clue 04";
            count1.text = displaycount;
        }
        else if (d2 == 5)
        {
            displaytext = " ‘Cavallo mi ha sfidato, ho fatto il toro’";
            countText.text = displaytext;
            displaycount = "Clue 05";
            count1.text = displaycount;
        }
        else if (d2 == 6)
        {
            displaytext = "I am headquartered in Guangdong but Bangalore experienced me first ";
            countText.text = displaytext;
            displaycount = "Clue 06";
            count1.text = displaycount;
        }
        else if (d2 == 7)
        {
            displaytext = " 1g/1000 = ? \n \n \n As I was near the treasure, I got 1g of gold. \n They said to divide it among 1000. \n I found the place.";
            countText.text = displaytext;
            displaycount = "Clue 07";
            count1.text = displaycount;
        }
        else if (d2 == 8)
        {
            displaytext = " Host wants you back - \n #aravind";
            countText.text = displaytext;
            displaycount = "Clue 08";
            count1.text = displaycount;
        }
        else
        {
            displaytext = "SEEK ";
            countText.text = displaytext;
        }


    }
}

