using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPicker : MonoBehaviour
{ 
     void OnMouseDown()
    {
        //take the color and drop it into the variable
        PaintGM.currentColor = GetComponent<SpriteRenderer>().color;
        Debug.Log(PaintGM.currentColor);
        //increases the order of the color so there is no flicker with erasing.
        //PaintGM.currentOrder += 1;
    }

}
