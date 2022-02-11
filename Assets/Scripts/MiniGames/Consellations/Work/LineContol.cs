using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineContol : MonoBehaviour
{ 
    private LineRenderer lr;
    private List<DotControl> dots;

    // when the game starts store this data
    private void Awake()
    {
        lr = GetComponent<LineRenderer>();
        lr.positionCount = 0;
        dots = new List<DotControl>();
    }
    // this till check to see how many dots are being madea ands the first point.
    public DotControl GetFirstPoint()
    {
        return dots[0];
    }
    //this will allow you to add dots to the game.
    public void AddDot(DotControl dot)
    {
        //this will count how many dots are in the index and store them
        dot.SetIndex(dots.Count);
        //this will call the lines and set them to the dots
        dot.SetLine(this);
        //this will get the line postion and count where the lines are at
        lr.positionCount++;
        //add new dots
        dots.Add(dot);
    }
    //this will check to see if there is dots in the index and check to see if before we start if dots are there otherwise check if dots have been made
    public void SplitPointsAtIndex(int index, out List<DotControl> beforeDots, out List<DotControl> afterDots)
    {
        List<DotControl> before = new List<DotControl>();
        List<DotControl> after = new List<DotControl>();
        //will store the count of dots being made
        int i = 0;
        for(; i < index; i++)
        {
            //will had how many dots are on screen
            before.Add(dots[i]);
        }
        i++;
        //if dots are there then add them to the index. 
        for(; i < dots.Count; i++)
        {
            after.Add(dots[i]);
            //lr.SetPosition(i, dots[i].transform.position);
        }
        beforeDots = before;
        afterDots = after;

        dots.RemoveAt(index);
    }
    //this will set the color of the lines to be alittle different when they are drawn
    public void SetColor(Color color)
    {
        lr.startColor = color;
        lr.endColor = color;
    }
    //this will allow the dots to connect with the firt dot being made
    public void ToggleLoop()
    {
        lr.loop = !lr.loop;
    }
    //this will check if the loop has been made
    public bool isLooped()
    {
        return lr.loop;

    }

//this is updating to check if lines and dots are being created and where the postion of them
    private void LateUpdate()
    {
        if (dots.Count >= 2)
        {
            for (int i = 0; i < dots.Count; i++)
            {
                Vector3 position = dots[i].transform.position;
                position += new Vector3(0, 0, 5);

                lr.SetPosition(i, position);
            }
        }
    }

}
