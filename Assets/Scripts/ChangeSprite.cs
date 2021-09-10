using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSprite : MonoBehaviour
{
    //Game Object to modify object image
    public GameObject objectImage;

    //Temp Text object to change object sprite in editor
    public Text objectSpriteText;

    //Array to hold the different objects (by text, but will change to image)
    public string[] objectSprites = new string[] {};

    //Variable to hold the index of the array
    public int objectSpritesIndex = 0;

    //Function to change the object's text
    //Once assets are made, will change image instead
    public void ChangeImage()
    {
        //TODO: Fix bug that doesn't change text to final item in array

        Debug.Log(objectSpritesIndex);
        objectSpritesIndex++;

        if (objectSpritesIndex > objectSprites.Length - 1)
        {
            objectSpritesIndex = 0;
            objectSpriteText.text = objectSprites[objectSpritesIndex];
        }
        else if (objectSpritesIndex < objectSprites.Length - 1)
        {
            objectSpriteText.text = objectSprites[objectSpritesIndex];
        }


        Debug.Log(objectSprites[objectSpritesIndex]);
    }
}
