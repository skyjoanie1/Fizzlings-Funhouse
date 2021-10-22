using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineContol : MonoBehaviour
{ 
    private LineRenderer lr;
    private List<DotControl> dots;


    private void Awake()
    {
        lr = GetComponent<LineRenderer>();
        lr.positionCount = 0;
        dots = new List<DotControl>();
    }
    public DotControl GetFirstPoint()
    {
        return dots[0];
    }
    public void AddPoint(DotControl dot)
    {
        dot.SetIndex(dots.Count);
        dot.SetLine(this);
        lr.positionCount++;
        dots.Add(dot);
    }
    public void SplitPointsAtIndex(int index, out List<DotControl> beforeDots, out List<DotControl> afterDots)
    {
        List<DotControl> before = new List<DotControl>();
        List<DotControl> after = new List<DotControl>();

        int i = 0;
        for(; i < index; i++)
        {
            before.Add(dots[i]);
        }
        i++;
        for(; i < dots.Count; i++)
        {
            lr.SetPosition(i, dots[i].transform.position);
        }
        beforeDots = before;
        afterDots = after;

        dots.RemoveAt(index);
    }
    public void SetColor(Color color)
    {
        lr.startColor = color;
        lr.endColor = color;
    }
    public void ToggleLoop()
    {
        lr.loop = !lr.loop;
    }
    public bool isLooped()
    {
        return lr.loop;
    }


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
