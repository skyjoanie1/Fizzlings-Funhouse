 using UnityEngine;
 using UnityEngine.UI;
 using System.Collections;
 using System.Collections.Generic;
 
 public class LoadNextImage : MonoBehaviour {
 
     public RectTransform ParentPanel;
     private List<string> ImageName;
     private int imageNum = 0;
 
     // Use this for initialization
     void Start () {
         ImageName = new List<string>();
 
         ImageName.Add ("Jupiter Respect Lesson");
         ImageName.Add ("Mars Healthy Food Lesson");
         ImageName.Add ("Mercury Honesty Lesson");
         ImageName.Add ("Neptune Forgiveness Lesson");
         ImageName.Add ("Saturn Grace Lesson");
         ImageName.Add ("Uranus Responsibility Lesson");
         ImageName.Add ("Venus Politeness Lesson");
         

 
         Debug.Log (ImageName.Count);
     }
 
     public void LoadNextPic(bool LeftRight)
     {
         if(LeftRight)    // right if true
         {
             imageNum ++;
             if (imageNum > ImageName.Count - 1)
                 imageNum = 0;
         }
         else
         {
             imageNum --;
             if(imageNum < 0)
                 imageNum = ImageName.Count - 1;
         }
 
         string tempName = ImageName[imageNum];
 
         Sprite mySprite =  Resources.Load <Sprite>(tempName);
         if (mySprite){
             ParentPanel.GetComponent<Image>().sprite = mySprite;
         } else {
             Debug.LogError("no sprite found ImageName = " + ImageName[imageNum]);
         }
     }
 }
