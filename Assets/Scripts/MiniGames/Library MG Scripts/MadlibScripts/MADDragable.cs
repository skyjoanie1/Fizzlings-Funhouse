using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class MADDragable : EventTrigger
{

    public delegate void DragEndedDelgate(MADDragable draggableObjects);
    public DragEndedDelgate dragEndedCallback;



    private bool dragging;

    public void Update()
    {
        if (dragging)
        {
            transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        }
    }

    
    public override void OnPointerDown(PointerEventData eventData)
    {
        dragging = true;
    }

    public override void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("Working");
        dragEndedCallback(this);
        dragging = false;
    }


}
