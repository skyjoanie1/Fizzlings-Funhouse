using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class DotControl : MonoBehaviour, IDragHandler, IPointerClickHandler, IBeginDragHandler
{
    public LineContol line;
    public int index;

    public Action<DotControl> OnDragEvent;
    public void OnDrag(PointerEventData eventData)
    {
        OnDragEvent?.Invoke(this);
    }

    public Action<DotControl> OnRightClickEvent;
    public Action<LineContol> OnLeftClickEvent;
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

    public void SetLine(LineContol line)
    {
        this.line = line;
    }
    public void SetIndex(int index)
    {
        this.index = index;
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        if (eventData.pointerId == -1)
        {
            //Left Drag

            OnLeftClickEvent?.Invoke(line);
        }
    }


}
