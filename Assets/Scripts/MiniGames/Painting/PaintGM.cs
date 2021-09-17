using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintGM : MonoBehaviour
{
    //Whats a comment
    //variable for the dot prefab
    public Transform baseDot;
    //mouse variable 
    public KeyCode mouseLeft;
    //tracks what type of tool is being used
    public static string toolType;
    //gets the current color clicked on
    public static Color currentColor;
    //gets the current layer for the color
    public static int currentOrder;

    public static int layerOrder;


    //current size of the brush
    public static float currentScale = .2f;

   void Update()
    {
        //Instantiates the baseDot prefab and updates the prostion
        Vector2 mousePostion = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        //this is filtering the view on the screen and adjusting it based on the camera location
        Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePostion);

        if (Input.GetKey(mouseLeft))
        {
            //creates the dot 
            Instantiate(baseDot, objPosition, baseDot.rotation);
            

        }


    }


}
