using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragFood : MonoBehaviour
{
    
    public delegate void DragEndedDelgate(DragFood draggableObjects);

    public DragEndedDelgate dragEndedCallback;
    //will check to see if the food is dragged
    private bool isDragged = false;
    //get the postion start postion of the mouse cursor
    private Vector3 mouseDragStartPostion;
    //gets the postion of the sprite that will be dragged. 
    private Vector3 spriteDragStartPostion;

    //if you mouse button is clicked do this. 
    private void OnMouseDown()
    {
        //if you are dragging the object move the sprite to new location
        isDragged = true;
        mouseDragStartPostion = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        spriteDragStartPostion = transform.localPosition;
    }
    private void OnMouseDrag()
    {
        if (isDragged)
        {
            //allows the object to move around and be in a ne location
            transform.localPosition = spriteDragStartPostion + (Camera.main.ScreenToWorldPoint(Input.mousePosition) - mouseDragStartPostion);

        }
    }
    //if you let go of the mouse do this
    private void OnMouseUp()
    {
       //if you arnt clicking the mouse object then the item will not move. 
        isDragged = false;
        dragEndedCallback(this);
    }
    //if the object enters this trigger do this
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if the object collides with the trigger and it matches pig destory object
        if (collision.transform.CompareTag("Pig"))
        {

            Destroy(gameObject);

        }

        if (collision.transform.CompareTag("Horse"))
        {

            Destroy(gameObject);

        }
        if (collision.transform.CompareTag("Sheep"))
        {

            Destroy(gameObject);

        }
    }

}

