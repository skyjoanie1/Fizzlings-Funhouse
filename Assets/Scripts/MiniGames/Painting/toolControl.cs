using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toolControl : MonoBehaviour
{
   
    void OnMouseDown()
    {
       
        //if you click on the earser erase the paint
        if (gameObject.name == "fizzling eraser")
        {
            PaintGM.toolType = "eraser";
            Debug.Log(" eraser selected");
           
        }
        //if the penicl is selected start drawing
        if(gameObject.name == "fizzling pencil")
        {
            PaintGM.toolType = "pencil";
         
            Debug.Log("pencil selected");
        }
       // if(gameObject.name == "size up")
       // {
           // PaintGM.currentScale = .6f;
        
       // }
       
    }

}
