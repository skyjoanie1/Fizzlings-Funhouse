using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DrawSelector : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public testDraw Mouse;
    public void OnPointerExit(PointerEventData eventData)
    {
        Mouse.Selecting = false;
        
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        //figure out a way to not deselect brush
            Mouse.Selecting = true;
            Mouse.redBrushActive = false;
            Mouse.greenBrushActive = false;
            Mouse.purpleBrushActive = false;
            Mouse.whiteBrushActive = false;
            Mouse.orangeBrushActive = false;
            Mouse.yellowBrushActive = false;
            Mouse.blueBrushActive = false;
            Mouse.brownBrushActive = false;
            Mouse.blackBrushActive = false;
            Mouse.eraseBrushActive = false;
    }


}
