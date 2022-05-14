using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapBook : MonoBehaviour
{
    //has the snappoints in a list
    public List<Transform> snapPoints;
    //has the tools in a list
    public List<DragBook> dragableObjects;
    //the distance it needs to snap
    public float snapRange = 1f;
    public Alphabet  letterScore;

    public WinCanvas score;
    
    private void Start()
    {
        //if the object is draggable
        foreach (DragBook dragable in dragableObjects)
        {
            dragable.dragEndedCallback = OnDragEnded;

        }
    }
    private void OnDragEnded(DragBook draggable)
    {
        float closestDistance = -1;
        Transform closestSnapPoint = null;

        foreach (Transform snapPoint in snapPoints)
        {
           // float currentDistance = Vector2.Distance(draggable.transform.position, snapPoint.position);
            float currentDistance = Vector2.Distance(draggable.transform.localPosition, snapPoint.localPosition);
            if (closestSnapPoint == null || currentDistance < closestDistance)
            {
                if(snapPoint.tag == "Rich")
                {
                    
                    if(draggable.tag == "Rich"){

                      
                        closestSnapPoint = snapPoint;
                        closestDistance = currentDistance;
                        score.score++;

                    }
                }
                if (snapPoint.tag == "Bob")
                {

                    if (draggable.tag == "Bob")
                    {


                        closestSnapPoint = snapPoint;
                        closestDistance = currentDistance;
                        score.score++;
                    }
                }
                if (snapPoint.tag == "Tod")
                {

                    if (draggable.tag == "Tod")
                    {


                        closestSnapPoint = snapPoint;
                        closestDistance = currentDistance;
                        score.score++;
                    }
                }
                if (snapPoint.tag == "Dog")
                {

                    if (draggable.tag == "Dog")
                    {


                        closestSnapPoint = snapPoint;
                        closestDistance = currentDistance;
                        score.score++;
                    }
                }
                if (snapPoint.tag == "Hanna")
                {

                    if (draggable.tag == "Hanna")
                    {


                        closestSnapPoint = snapPoint;
                        closestDistance = currentDistance;
                        score.score++;
                    }
                }
                if (snapPoint.tag == "Milk")
                {

                    if (draggable.tag == "Milk")
                    {


                        closestSnapPoint = snapPoint;
                        closestDistance = currentDistance;
                        score.score++;
                    }
                }
            }

            

        }
        if (closestSnapPoint != null && closestDistance <= snapRange)
        {
            draggable.transform.localPosition = closestSnapPoint.localPosition;
        }

    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Rich"))
        {
            score.score++;
        Debug.Log("does it work this way??");
        }
            
    }

}
