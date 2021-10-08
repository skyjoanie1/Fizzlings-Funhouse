using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class testDraw : MonoBehaviour 
{
    //gets the postion of the camera
    public Camera m_camera;
    // gets the default brush gameobject
    public GameObject brush;
    public GameObject Gbrush;
    public GameObject Rbrush;
    public GameObject Pbrush;
    public GameObject Obrush;
    public GameObject Ybrush;
    public GameObject blubrush;
    public GameObject brobrush;
    public GameObject blabrush;
    public GameObject eraseBrush;
    //calls the line to draw
    LineRenderer currentLineRenderer;
    //gets the postion of the mouse 
    public Vector3 mousePos;
    //gets the last postion of the mouse was at
    Vector3 lastPos;
    public bool redBrushActive;
    public bool greenBrushActive;
    public bool purpleBrushActive;
    public bool whiteBrushActive;
    public bool orangeBrushActive;
    public bool yellowBrushActive;
    public bool blueBrushActive;
    public bool brownBrushActive;
    public bool blackBrushActive;
    public bool Selecting;
    public bool eraseBrushActive;

  //will create the brush allowing you to draw
    public void CreateBrush()
    {
        if(whiteBrushActive == true)
        {
            GameObject brushInstance = Instantiate(brush);
            currentLineRenderer = brushInstance.GetComponent<LineRenderer>();
            mousePos = m_camera.ScreenToWorldPoint(Input.mousePosition);
            currentLineRenderer.SetPosition(0, mousePos);
            currentLineRenderer.SetPosition(1, mousePos);
        }
        // if the green brush is selected start drawing 
         if (greenBrushActive == true)
        {
            //creates the brush
            GameObject brushInstance = Instantiate(Gbrush);
            //gets the line render compoenenet and ties it with the current postion of the line
            currentLineRenderer = brushInstance.GetComponent<LineRenderer>();
            //gets the postion of the mouse on screen and allows the line to be drawn
            mousePos = m_camera.ScreenToWorldPoint(Input.mousePosition);
            currentLineRenderer.SetPosition(0, mousePos);
            currentLineRenderer.SetPosition(1, mousePos);

        }
        // if the red brush is selected start drawing 
         if (redBrushActive == true)
        {
            //creates the brush
            GameObject brushInstance = Instantiate(Rbrush);
            //gets the line render compoenenet and ties it with the current postion of the line
            currentLineRenderer = brushInstance.GetComponent<LineRenderer>();
            //gets the postion of the mouse on screen and allows the line to be drawn
            mousePos = m_camera.ScreenToWorldPoint(Input.mousePosition);
            currentLineRenderer.SetPosition(0, mousePos);
            currentLineRenderer.SetPosition(1, mousePos);
        }
        // if the purple brush is selected start drawing 
         if (purpleBrushActive == true)
        {
            ////creates the brush
            GameObject brushInstance = Instantiate(Pbrush);
            //gets the line render compoenenet and ties it with the current postion of the line
            currentLineRenderer = brushInstance.GetComponent<LineRenderer>();
            //gets the postion of the mouse on screen and allows the line to be drawn
            mousePos = m_camera.ScreenToWorldPoint(Input.mousePosition);
            currentLineRenderer.SetPosition(0, mousePos);
            currentLineRenderer.SetPosition(1, mousePos);
        }
        // if the orange brush is selected start drawing 
        if (orangeBrushActive == true)
        {
            ////creates the brush
            GameObject brushInstance = Instantiate(Obrush);
            //gets the line render compoenenet and ties it with the current postion of the line
            currentLineRenderer = brushInstance.GetComponent<LineRenderer>();
            //gets the postion of the mouse on screen and allows the line to be drawn
            mousePos = m_camera.ScreenToWorldPoint(Input.mousePosition);
            currentLineRenderer.SetPosition(0, mousePos);
            currentLineRenderer.SetPosition(1, mousePos);
        }
        // if the yellow brush is selected start drawing 
        if (yellowBrushActive == true)
        {
            ////creates the brush
            GameObject brushInstance = Instantiate(Ybrush);
            //gets the line render compoenenet and ties it with the current postion of the line
            currentLineRenderer = brushInstance.GetComponent<LineRenderer>();
            //gets the postion of the mouse on screen and allows the line to be drawn
            mousePos = m_camera.ScreenToWorldPoint(Input.mousePosition);
            currentLineRenderer.SetPosition(0, mousePos);
            currentLineRenderer.SetPosition(1, mousePos);
        }
        // if the blue brush is selected start drawing 
        if (blueBrushActive == true)
        {
            ////creates the brush
            GameObject brushInstance = Instantiate(blubrush);
            //gets the line render compoenenet and ties it with the current postion of the line
            currentLineRenderer = brushInstance.GetComponent<LineRenderer>();
            //gets the postion of the mouse on screen and allows the line to be drawn
            mousePos = m_camera.ScreenToWorldPoint(Input.mousePosition);
            currentLineRenderer.SetPosition(0, mousePos);
            currentLineRenderer.SetPosition(1, mousePos);
        }
        // if the brown brush is selected start drawing 
        if (brownBrushActive == true)
        {
            ////creates the brush
            GameObject brushInstance = Instantiate(brobrush);
            //gets the line render compoenenet and ties it with the current postion of the line
            currentLineRenderer = brushInstance.GetComponent<LineRenderer>();
            //gets the postion of the mouse on screen and allows the line to be drawn
            mousePos = m_camera.ScreenToWorldPoint(Input.mousePosition);
            currentLineRenderer.SetPosition(0, mousePos);
            currentLineRenderer.SetPosition(1, mousePos);
        }
        // if the black brush is selected start drawing 
        if (blackBrushActive == true)
        {
            ////creates the brush
            GameObject brushInstance = Instantiate(blabrush);
            //gets the line render compoenenet and ties it with the current postion of the line
            currentLineRenderer = brushInstance.GetComponent<LineRenderer>();
            //gets the postion of the mouse on screen and allows the line to be drawn
            mousePos = m_camera.ScreenToWorldPoint(Input.mousePosition);
            currentLineRenderer.SetPosition(0, mousePos);
            currentLineRenderer.SetPosition(1, mousePos);
        }
        //erases tge brushes in the game.
        if (eraseBrushActive == true)
        {
            //creates the brush
            GameObject brushInstance = Instantiate(eraseBrush);
            //gets the line render compoenenet and ties it with the current postion of the line
            currentLineRenderer = brushInstance.GetComponent<LineRenderer>();
            //gets the postion of the mouse on screen and allows the line to be drawn
            mousePos = m_camera.ScreenToWorldPoint(Input.mousePosition);
            currentLineRenderer.SetPosition(0, mousePos);
            currentLineRenderer.SetPosition(1, mousePos);

        }


    }
    public void erasedBrush()
    {
        if (eraseBrushActive == true)
        {
            //creates the brush
            GameObject brushInstance = Instantiate(eraseBrush);
            //gets the line render compoenenet and ties it with the current postion of the line
            currentLineRenderer = brushInstance.GetComponent<LineRenderer>();
            //gets the postion of the mouse on screen and allows the line to be drawn
            mousePos = m_camera.ScreenToWorldPoint(Input.mousePosition);
            currentLineRenderer.SetPosition(0, mousePos);
            currentLineRenderer.SetPosition(1, mousePos);
            
        }
    }

    //allows the line render to draw
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
            if(mousePos != lastPos)
            {
                AddAPoint(mousePos);
                lastPos = mousePos;
                
            }
           
        }
        else
        {
            currentLineRenderer = null;
        }

    }

    public void GreenBrush()
    {
            greenBrushActive = true;
    }
    public void RedBrush()
    {
        redBrushActive = true;
    }
    public void PurpleBrush()
    {
        purpleBrushActive = true;
    }
    public void WhiteBrush()
    {
        whiteBrushActive = true;
    }
    public void OrangeBrush()
    {
        orangeBrushActive = true;
    }
    public void YellowBrush()
    {
        yellowBrushActive = true;
    }
    public void BlueBrush()
    {
        blueBrushActive = true;
    }
    public void BrownBrush()
    {
        brownBrushActive = true;
    }
    public void BlackBrush()
    {
        blackBrushActive = true;
    }

    public void EraseBrush()
    {
        eraseBrushActive = true;
    }

    // it will get the point of the mouse and when you click on the screen create the line
    void AddAPoint(Vector2 pointPos)
    {
        //gets line postion and allows you to draw
        currentLineRenderer.positionCount++;
        // puts the postion in a index and count 
        int positionIndex = currentLineRenderer.positionCount - 1;
        // gets the postion and of the line and where the mouse is. 
        currentLineRenderer.SetPosition(positionIndex, pointPos);
    }

    private void Update()
    {
        //will only draw if you press the mosue button
        if(Input.GetMouseButton(0))
        {
            Draw();
        } 
    }

    
}
