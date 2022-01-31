using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{

    private SpriteRenderer SRenderer;
    public Sprite defaultImage;
    public Sprite pressedImage;

    public KeyCode keyToPress;

    // Start is called before the first frame update
    void Start()
    {

        SRenderer = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(keyToPress) && gameObject.tag == "Activator")
        {
            // If arrow keys are pressed down the image will change to the pressed color image
            SRenderer.sprite = pressedImage;

        }

        if (Input.GetKeyUp(keyToPress) && gameObject.tag == "Activator")
        {
            // If arrow keys are released the image will return to the default color image
            SRenderer.sprite = defaultImage;

        }


    }
}
