using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stars : MonoBehaviour
{
    public bool Selecting;
    private LineRenderer lr;
    private Transform[] points;



    //gets the postion of the camera
    public Camera m_camera;
    public GameObject brush;
    //gets the postion of the mouse 
    public Vector3 mousePos;
    //gets the last postion of the mouse was at
    Vector3 lastPos;

    public bool whiteBrushActive;
    public bool drawTool;
    public bool drawTool1;

    private void Awake()
    {
        lr = GetComponent<LineRenderer>();

    }
    // set postion of the line to the dot
    public void SetUpLine(Transform[] points)
    {
        lr.positionCount = points.Length;

        this.points = points;


        //if point is set 

    }

    // draw line
    public void DrawLine()
    {
        //if button is highlighted
        //if button is selected
        //if (Input.GetKeyDown(KeyCode.Mouse0) && Selecting != true)
        if (drawTool == true)
        {
            for (int i = 0; i < points.Length; i++)
            {
                lr.SetPosition(i, points[i].position);
            }

        }
        if (drawTool1 == true)
        {
            for (int i = 0; i < points.Length; i++)
            {
                lr.SetPosition(i, points[i].position);
            }

        }
    }
    public void Tool()
    {
        drawTool = true;
    }
    public void Tool1()
    {
        drawTool1 = true;
    }
    //if line is drawn
    // look for next button
    //if button is highlighted connect to dot
    public void Update()
    {
        DrawLine();
        //Draw();
    }


    public void CreateBrush()
    {
        if (whiteBrushActive == true)
        {
            GameObject brushInstance = Instantiate(brush);
            lr = brushInstance.GetComponent<LineRenderer>();
            mousePos = m_camera.ScreenToWorldPoint(Input.mousePosition);
            lr.SetPosition(0, mousePos);
            lr.SetPosition(1, mousePos);

        }
    }

    public void Draw()
    {
        //if you click the mouse button it will call the create brush function 
        if (Input.GetKeyDown(KeyCode.Mouse0) && Selecting != true)
        {
            CreateBrush();
        }
        if (Input.GetKey(KeyCode.Mouse0) && Selecting != true)
        {
            //it will ge the mouse postion from the screen and get the current postion and the last postion it was at
            mousePos = m_camera.ScreenToWorldPoint(Input.mousePosition);
            if (mousePos != lastPos)
            {
                AddAPoint(mousePos);
                lastPos = mousePos;
            }
        }
        else
        {
            lr = null;
        }

    }
    void AddAPoint(Vector2 pointPos)
    {
        //gets line postion and allows you to draw
        lr.positionCount++;
        // puts the postion in a index and count 
        int positionIndex = lr.positionCount - 1;
        // gets the postion and of the line and where the mouse is. 
        lr.SetPosition(positionIndex, pointPos);
    }
    public void WhiteBrush()
    {
        whiteBrushActive = true;
    }


}