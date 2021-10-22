using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PenTool : MonoBehaviour
{
    [Header("Pen Canvas")]
    [SerializeField] private PenCanvas penCanvas;

    [Header("Dots")]
    [SerializeField] private GameObject dotPrefab;
    [SerializeField] Transform dotParent;
    [Header("Lines")]
    [SerializeField] private GameObject linePrefab;
    [SerializeField] Transform lineParent;
    private LineContol currentLine;

    [Header("Colors")]
    [SerializeField] private Color activeColor;
    [SerializeField] private Color normalColor;

    [Header("Loop Toggle")]
    [SerializeField] Image loopToggle;
    [SerializeField] Sprite loopSprite;
    [SerializeField] Sprite unloopSprite;

    private void Start()
    {
        penCanvas.OnPenCanvasLeftClickEvent += AddDot;
        penCanvas.OnPenCanvasRightClickEvent += EndCurrentLine;
    }

    public void ToggleLoop()
    {
        if(currentLine != null)
        {
            currentLine.ToggleLoop();
            loopToggle.sprite = (currentLine.isLooped()) ? unloopSprite : loopSprite;
        }
    }


    private void EndCurrentLine()
    {
     if(currentLine != null)
        {
            currentLine.SetColor(normalColor);
            loopToggle.enabled = false;
            currentLine = null;
        }   
    }

    private void AddDot()
    {
        if (currentLine == null)
        {
            currentLine = Instantiate(linePrefab, Vector3.zero, Quaternion.identity, lineParent).GetComponent<LineContol>();

        }
        DotControl dot = Instantiate(dotPrefab, GetMousePostion(), Quaternion.identity, dotParent).GetComponent<DotControl>();
        dot.OnDragEvent += MoveDot;
        dot.OnRightClickEvent += RemoveDot;
        dot.OnLeftClickEvent += SetCurrentLine;
        currentLine.AddPoint(dot);
    }

    private void SetCurrentLine(LineContol newLine)
    {
        EndCurrentLine();
        currentLine = newLine;
        currentLine.SetColor(activeColor);
        loopToggle.enabled = true;
        loopToggle.sprite = (currentLine.isLooped()) ? unloopSprite : loopSprite;
    }
private void MoveDot(DotControl dot)
    {
        dot.transform.position = GetMousePostion();
    }
    private void RemoveDot(DotControl dot)
    {
        
            dot.line.SplitPointsAtIndex(dot.index, out List<DotControl> before, out List<DotControl> after);
            Destroy(dot.line.gameObject);
            Destroy(dot.gameObject);

        LineContol beforeLine = Instantiate(linePrefab, Vector3.zero, Quaternion.identity, lineParent).GetComponent<LineContol>();

        for (int i = 0; i < before.Count; i++)
        {
            beforeLine.AddPoint(before[i]);
        }

        LineContol afterLine = Instantiate(linePrefab, Vector3.zero, Quaternion.identity, lineParent).GetComponent<LineContol>();

        for (int i = 0; i < after.Count; i++)
        {
            afterLine.AddPoint(after[i]);
        }


    }
    private Vector3 GetMousePostion()
    {
        Vector3 worldMousePostion = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        worldMousePostion.z = 0;

        return worldMousePostion;
    }

}
