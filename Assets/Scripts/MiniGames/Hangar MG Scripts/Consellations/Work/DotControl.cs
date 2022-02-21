using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class DotControl : MonoBehaviour, IDragHandler, IPointerClickHandler, IBeginDragHandler
{
    //calls the linecontrol script
    public LineContol line;
    //stores things in a index
    public int index;
    //allows you to call mutliple functions with the script with ondrag
    public Action<DotControl> OnDragEvent;

    //will call the drag event for when you drag a object around do this.
    public void OnDrag(PointerEventData eventData)
    {
        OnDragEvent?.Invoke(this);
    }
    // when you right click on the dots you can do this event
    public Action<DotControl> OnRightClickEvent;
    // when you left click this will control the lines
    public Action<LineContol> OnLeftClickEvent;
    // will detect if you have clicked the canvas.
    public void OnPointerClick(PointerEventData eventData)
    {
        if(eventData.pointerId == -2)
        {
            //right click
            OnRightClickEvent?.Invoke(this);
        }
        else if (eventData.pointerId == -1)
        {
            //left click
            OnLeftClickEvent?.Invoke(line);
        }
    }
    // this will set the line that is being drawn.
    public void SetLine(LineContol line)
    {
        this.line = line;
    }
    //this will allow you to set the index and store info
    public void SetIndex(int index)
    {
        this.index = index;
    }
    //this will call the drag event and will check to see if you have clicked things.
    public void OnBeginDrag(PointerEventData eventData)
    {
        if (eventData.pointerId == -1)
        {
            //Left Drag

            OnLeftClickEvent?.Invoke(line);
        }
    }


}
