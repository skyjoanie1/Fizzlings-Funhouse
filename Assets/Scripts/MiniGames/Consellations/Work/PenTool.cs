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
    //this is checking to see if there is a current line made and if so have it loop back to the first dot
    public void ToggleLoop()
    {
        if(currentLine != null)
        {

            currentLine.ToggleLoop();
            
            loopToggle.sprite = (currentLine.isLooped()) ? unloopSprite : loopSprite;
        }

        
    }

    //this will end the current line allowing a new line to be made 
    private void EndCurrentLine()
    {
     if(currentLine != null)
        {
            currentLine.SetColor(normalColor);
            loopToggle.enabled = false;
            currentLine = null;
        }   
    }
    //this will create the dots and lines allowing them to instaniate on screen. 
    private void AddDot()
    {
        if (currentLine == null)
        {
            //LineContol lineContol = Instantiate(linePrefab, Vector3.zero, Quaternion.identity, lineParent).GetComponent<LineContol>();
             currentLine = Instantiate(linePrefab, Vector3.zero, Quaternion.identity, lineParent).GetComponent<LineContol>();
            //SetCurrentLine(lineContol);
        }
        DotControl dot = Instantiate(dotPrefab, GetMousePostion(), Quaternion.identity, dotParent).GetComponent<DotControl>();
        dot.OnDragEvent += MoveDot;
        dot.OnRightClickEvent += RemoveDot;
        dot.OnLeftClickEvent += SetCurrentLine;
        currentLine.AddDot(dot);
    }
    // this will set the current line we have made and will have the new line you make be the current line
    private void SetCurrentLine(LineContol newLine)
    {
        EndCurrentLine();
        currentLine = newLine;
        currentLine.SetColor(activeColor);
        loopToggle.enabled = true;
        loopToggle.sprite = (currentLine.isLooped()) ? unloopSprite : loopSprite;
        
    }
    //this will allow the dots to be moved around to how you want. 
private void MoveDot(DotControl dot)
    {
        dot.transform.position = GetMousePostion();
    }
    //this will remove the dot that you have accidently made by left clicking on the dot
    private void RemoveDot(DotControl dot)
    {
            dot.line.SplitPointsAtIndex(dot.index, out List<DotControl> before, out List<DotControl> after);
            Destroy(dot.line.gameObject);
            Destroy(dot.gameObject);

        LineContol beforeLine = Instantiate(linePrefab, Vector3.zero, Quaternion.identity, lineParent).GetComponent<LineContol>();

        for (int i = 0; i < before.Count; i++)
        {
            beforeLine.AddDot(before[i]);
        }

        LineContol afterLine = Instantiate(linePrefab, Vector3.zero, Quaternion.identity, lineParent).GetComponent<LineContol>();

        for (int i = 0; i < after.Count; i++)
        {
            afterLine.AddDot(after[i]);
        }


    }
    //this will get the current mouse postion and set it to the world postion. 
    private Vector3 GetMousePostion()
    {
        Vector3 worldMousePostion = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        worldMousePostion.z = 0;

        return worldMousePostion;
    }

}
