using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasChange : MonoBehaviour
{
    //Game Object to modify object image
    public SpriteRenderer objectImage;

    //Array to hold the different objects (by text, but will change to image)
    public Sprite[] objectSprites = new Sprite[] { };

    //Variable to hold the index of the array
    public int objectSpritesIndex = 0;

    //Function to change the object's text
    //Once assets are made, will change image instead
    public void ChangeImage()
    {


        Debug.Log(objectSpritesIndex);
        objectSpritesIndex++;

        if (objectSpritesIndex >= objectSprites.Length)
        {
            objectSpritesIndex = 0;
            objectImage.sprite = objectSprites[objectSpritesIndex];
        }
        else if (objectSpritesIndex < objectSprites.Length)
        {
            objectImage.sprite = objectSprites[objectSpritesIndex];
        }


        Debug.Log(objectSprites[objectSpritesIndex]);
    }
}
