using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasClear : MonoBehaviour
{
    public void DestroyAll(string tag)
    {
        GameObject[] PaintOnCanvas = GameObject.FindGameObjectsWithTag(tag);
        for (int i = 0; i < PaintOnCanvas.Length; i++)
        {
            Destroy(PaintOnCanvas[i]);
        }
    }

}
