using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapFood : MonoBehaviour
{
    //has the snappoints in a list
    public List<Transform> snapPoints;
    //has the tools in a list
    public List<DragFood> dragableObjects;
    //the distance it needs to snap
    public float snapRange = 1f;

   // public List<TestDrag> dragableObject;

    private void Start()
    {
        //if the object is draggable
       foreach (DragFood dragFood in dragableObjects)
        {
            dragFood.dragEndedCallback = OnDragEnded;
       

        }
    }
   // private void OnDragEnded(TestDrag draggable)
    private void OnDragEnded(DragFood draggable)
    {
        float closestDistance = -1;
        Transform closestSnapPoint = null;

        foreach (Transform snapPoint in snapPoints)
        {

            float currentDistance = Vector2.Distance(draggable.transform.localPosition, snapPoint.localPosition);
            if (closestSnapPoint == null || currentDistance < closestDistance)
            {
                if (snapPoint.tag == "Pig")
                {
                    if (draggable.tag == "Pig")
                    {
                        
                        closestSnapPoint = snapPoint;
                        closestDistance = currentDistance;
                        
                    }
                }
                if (snapPoint.tag == "Horse")
                {
                    if (draggable.tag == "Horse")
                    {
                        
                        closestSnapPoint = snapPoint;
                        closestDistance = currentDistance;
                    }
                }
                if (snapPoint.tag == "Sheep")
                {
                    if (draggable.tag == "Sheep")
                    {
                        
                        closestSnapPoint = snapPoint;
                        closestDistance = currentDistance;
                    }
                }
                if (snapPoint.tag == "Flashlight")
                {
                    if (draggable.tag == "Flashlight")
                    {
                        
                        closestSnapPoint = snapPoint;
                        closestDistance = currentDistance;
                    }
                }
                

            }
        }
        if (closestSnapPoint != null && closestDistance <= snapRange)
        {
            draggable.transform.localPosition = closestSnapPoint.localPosition;
        }

    }

}

