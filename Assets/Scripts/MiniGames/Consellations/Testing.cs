using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Testing : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private Transform[] points;

    [SerializeField] private Stars star;

    private void Start()
    {
        // star.SetUpLine(points);
    }
    public void OnPointerExit(PointerEventData eventData)
    {

        star.Selecting = false;

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        //figure out a way to not deselect brush
        star.Selecting = true;
        star.whiteBrushActive = false;
        // star.drawTool = false;
        //star.drawTool1 = false;

        if (star.drawTool == false)
        {
            star.SetUpLine(points);
        }
        else
        {
            star.drawTool = false;
        }
        if (star.drawTool1 == false)
        {
            star.SetUpLine(points);
        }
        else
        {
            star.drawTool1 = false;
        }
    }
}
