using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    //hearts in array
    public GameObject[] cowhearts;
    //number of lives. 
    public int life;

  
    private void Start()
    {
        //start game with the amount of life you gave
        life = cowhearts.Length;
     
    }
    //take damage if you can't provide food in time
   public void TakeDamage(int d)
    {
        if(life >= 1)
        {
            //subtract a heart
            life -= d;
            //destroy a heart
           Destroy(cowhearts[life].gameObject);
          
        }
    }
}
