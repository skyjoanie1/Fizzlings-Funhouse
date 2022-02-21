using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MADSnapObjects : MonoBehaviour
{
    //has the snappoints in a list
    public List<Transform> snapPoints;
    //has the tools in a list
    public List<MADDragable> dragableObjects;
    //the distance it needs to snap
    public float snapRange = 1f;
   

    private void Start()
    {
        //if the object is draggable
        foreach(MADDragable dragable in dragableObjects)
        {
            dragable.dragEndedCallback = OnDragEnded;
            
        }
    }
    private void OnDragEnded(MADDragable draggable)
    {
        Debug.Log("Snapping");
        float closestDistance = -1;
        Transform closestSnapPoint = null;

        foreach (Transform snapPoint in snapPoints)
        {
           
            float currentDistance = Vector2.Distance(draggable.transform.position, snapPoint.transform.position);
            if (closestSnapPoint == null || currentDistance < closestDistance)
            {
                if (snapPoint.tag == "Nouns")
                {
                    if(draggable.tag == "Nouns")
                    {
                    
                    closestSnapPoint = snapPoint;
                    closestDistance = currentDistance;
                    }
                }
                if (snapPoint.tag == "Verbs")
                {
                    if (draggable.tag == "Verbs")
                    {
                        
                        closestSnapPoint = snapPoint;
                        closestDistance = currentDistance;
                    }
                }
                if (snapPoint.tag == "Names")
                {
                    if (draggable.tag == "Names")
                    {
                        
                        closestSnapPoint = snapPoint;
                        closestDistance = currentDistance;
                    }
                }
                if (snapPoint.tag == "Adjectives")
                {
                    if (draggable.tag == "Adjectives")
                    {
                        
                        closestSnapPoint = snapPoint;
                        closestDistance = currentDistance;
                    }
                }
                
                
            }
        }
        if(closestSnapPoint != null && closestDistance <= snapRange)
        {
            draggable.transform.position = closestSnapPoint.position;
        }
    
    }

}
