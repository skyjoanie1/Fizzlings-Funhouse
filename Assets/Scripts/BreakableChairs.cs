using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BreakableChairs : MonoBehaviour
{
    //GameObject to manipulate the breakable chair image
    public GameObject chairImage;

    //Temp reference to button text
    public Text breakableChairText;

    //Function for when the chair is clicked
    public void BreakChair()
    {
        //When the chair is clicked, change the text
        //Once assets are made, change the image instead
        if (breakableChairText.text == "Unbroken")
        {
            breakableChairText.text = "Broken";
        }
    }
}
