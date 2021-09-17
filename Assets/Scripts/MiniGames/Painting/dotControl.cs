using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dotControl : MonoBehaviour
{
    void Start()
    {
        GetComponent<SpriteRenderer>().color = PaintGM.currentColor;
        GetComponent<Transform>().localScale = new Vector2(PaintGM.currentScale, PaintGM.currentScale);
    }
    void OnMouseOver()
    {
        //if you click on the earser icon do this
       if(PaintGM.toolType == "eraser")
        Destroy(gameObject);

    }
}
