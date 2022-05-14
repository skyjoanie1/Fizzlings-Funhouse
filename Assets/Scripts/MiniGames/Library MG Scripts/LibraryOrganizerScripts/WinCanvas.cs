using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinCanvas : MonoBehaviour
{
    public int score;
    public Text loseText;
    public Text winText;
    public GameObject winBackGround;
   // public GameObject hub;
    public void WinCondition()
    {
    if(score == 6)
        {
            winBackGround.SetActive(true);
          //  hub.SetActive(true);
            winText.enabled = true;
        }
    }

    public void LoseCondition()
    {
       StartCoroutine(lose());
    }

    IEnumerator lose()
    {
        if (score < 6)
        {
            loseText.enabled = true;
            yield return new WaitForSeconds(2);
            loseText.enabled = false;

        }
        
    }

    public void Start()
    {
        loseText.enabled = false;
        winText.enabled = false;
        winBackGround.SetActive(false);
       // hub.SetActive(false);
    }
}
