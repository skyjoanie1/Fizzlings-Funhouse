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

    // Gets Color Selector from Canvas
    public GameObject ColorPallet;
    // Gets Painting Canvas
    public GameObject PalletButton;
    public bool canDraw;


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
        //if the greenbrush is not active do nothing
       //if (greenBrushActive == false)
       // {
       //     GameObject brushInstance = Instantiate(brush);
       //     currentLineRenderer = brushInstance.GetComponent<LineRenderer>();
       //     mousePos = m_camera.ScreenToWorldPoint(Input.mousePosition);
       //     currentLineRenderer.SetPosition(0, mousePos);
       //     currentLineRenderer.SetPosition(1, mousePos);
       // } 
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
    }
    //allows the line render to draw
   private void Draw()
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
        // Hides ColorPallet GameObject
        ColorPallet.SetActive(false);
        Selecting = false;
    }
    public void RedBrush()
    {
        
        redBrushActive = true;
        // Hides ColorPallet GameObject
        ColorPallet.SetActive(false);
        Selecting = false;

    }
    public void PurpleBrush()
    {
        purpleBrushActive = true;
        // Hides ColorPallet GameObject
        ColorPallet.SetActive(false);
        Selecting = false;
    }
    public void WhiteBrush()
    {
        whiteBrushActive = true;
        // Hides ColorPallet GameObject
        ColorPallet.SetActive(false);
        Selecting = false;
    }
    public void OrangeBrush()
    {
        orangeBrushActive = true;
        // Hides ColorPallet GameObject
        ColorPallet.SetActive(false);
        Selecting = false;
    }
    public void YellowBrush()
    {
        yellowBrushActive = true;
        // Hides ColorPallet GameObject
        ColorPallet.SetActive(false);
        Selecting = false;
    }
    public void BlueBrush()
    {
        blueBrushActive = true;
        // Hides ColorPallet GameObject
        ColorPallet.SetActive(false);
        Selecting = false;
    }
    public void BrownBrush()
    {
        brownBrushActive = true;
        // Hides ColorPallet GameObject
        ColorPallet.SetActive(false);
        Selecting = false;
    }
    public void BlackBrush()
    {
        blackBrushActive = true;
        // Hides ColorPallet GameObject
        ColorPallet.SetActive(false);
        Selecting = false;
    }

    public void ShowColorSelect()
    {

        ColorPallet.SetActive(true);
        Selecting = true;
        redBrushActive = false;
        greenBrushActive = false;
        purpleBrushActive = false;
        whiteBrushActive = false;
        orangeBrushActive = false;
        yellowBrushActive = false;
        blueBrushActive = false;
        brownBrushActive = false;
        blackBrushActive = false;

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
        if(Input.GetMouseButton(0) && canDraw != false)
        {
            
            Draw();
        }

        if(mousePos.x > -4.5 && mousePos.x < 6.45 && mousePos.y < 4.8 && mousePos.y > -3.4)
        {

            canDraw = true;

        } else if (mousePos.x < -4.5 || mousePos.x > 6.45 || mousePos.y > 4.8 || mousePos.y < -3.4)
        {

            canDraw = false;

        }

        


        mousePos = m_camera.ScreenToWorldPoint(Input.mousePosition);

    }

    
 

}
