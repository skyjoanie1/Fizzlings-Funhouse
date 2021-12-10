using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragFood : MonoBehaviour
{
    public delegate void DragEndedDelgate(DragFood draggableObjects);
    public DragEndedDelgate dragEndedCallback;

    private bool isDragged = false;
    private Vector3 mouseDragStartPostion;
    private Vector3 spriteDragStartPostion;

    private void OnMouseDown()
    {
        isDragged = true;
        mouseDragStartPostion = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        spriteDragStartPostion = transform.localPosition;
    }
    private void OnMouseDrag()
    {
        if (isDragged)
        {
            transform.localPosition = spriteDragStartPostion + (Camera.main.ScreenToWorldPoint(Input.mousePosition) - mouseDragStartPostion);

        }
    }
    private void OnMouseUp()
    {
        isDragged = false;
        dragEndedCallback(this);
    }
}

