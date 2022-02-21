using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapObjects : MonoBehaviour
{
    //has the snappoints in a list
    public List<Transform> snapPoints;
    //has the tools in a list
    public List<Dragable> dragableObjects;
    //the distance it needs to snap
    public float snapRange = 1f;
   

    private void Start()
    {
        //if the object is draggable
        foreach(Dragable dragable in dragableObjects)
        {
            dragable.dragEndedCallback = OnDragEnded;
            
        }
    }
    private void OnDragEnded(Dragable draggable)
    {
        float closestDistance = -1;
        Transform closestSnapPoint = null;

        foreach (Transform snapPoint in snapPoints)
        {
           
            float currentDistance = Vector2.Distance(draggable.transform.localPosition, snapPoint.localPosition);
            if (closestSnapPoint == null || currentDistance < closestDistance)
            {
                if (snapPoint.tag == "Hammer")
                {
                    if(draggable.tag == "Hammer")
                    {
                    GameManager.Instance.ToolsTotalPoints++;
                    closestSnapPoint = snapPoint;
                    closestDistance = currentDistance;
                    }
                }
                if (snapPoint.tag == "Wrench")
                {
                    if (draggable.tag == "Wrench")
                    {
                        GameManager.Instance.ToolsTotalPoints++;
                        closestSnapPoint = snapPoint;
                        closestDistance = currentDistance;
                    }
                }
                if (snapPoint.tag == "TapeMeasure")
                {
                    if (draggable.tag == "TapeMeasure")
                    {
                        GameManager.Instance.ToolsTotalPoints++;
                        closestSnapPoint = snapPoint;
                        closestDistance = currentDistance;
                    }
                }
                if (snapPoint.tag == "Flashlight")
                {
                    if (draggable.tag == "Flashlight")
                    {
                        GameManager.Instance.ToolsTotalPoints++;
                        closestSnapPoint = snapPoint;
                        closestDistance = currentDistance;
                    }
                }
                if (snapPoint.tag == "DuctTape")
                {
                    if (draggable.tag == "DuctTape")
                    {
                        GameManager.Instance.ToolsTotalPoints++;
                        closestSnapPoint = snapPoint;
                        closestDistance = currentDistance;
                    }
                }
                if (snapPoint.tag == "SafetyGlasses")
                {
                    if (draggable.tag == "SafetyGlasses")
                    {
                        GameManager.Instance.ToolsTotalPoints++;
                        closestSnapPoint = snapPoint;
                        closestDistance = currentDistance;
                    }
                }
                if (snapPoint.tag == "ScrewDriver")
                {
                    if (draggable.tag == "ScrewDriver")
                    {
                        GameManager.Instance.ToolsTotalPoints++;
                        closestSnapPoint = snapPoint;
                        closestDistance = currentDistance;
                    }
                }
                
            }
        }
        if(closestSnapPoint != null && closestDistance <= snapRange)
        {
            draggable.transform.localPosition = closestSnapPoint.localPosition;
        }
    
    }

}
