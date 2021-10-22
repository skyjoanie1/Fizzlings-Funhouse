using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PenCanvas : MonoBehaviour, IPointerClickHandler
{
    public Action OnPenCanvasLeftClickEvent;
    public Action OnPenCanvasRightClickEvent;
     void IPointerClickHandler.OnPointerClick(PointerEventData eventData)
    {
        if(eventData.pointerId == -1)
        {
            //left click
            OnPenCanvasLeftClickEvent?.Invoke();
        }
       else if (eventData.pointerId == -2)
        {
            //right click
            OnPenCanvasRightClickEvent?.Invoke();
        }
    }
}

