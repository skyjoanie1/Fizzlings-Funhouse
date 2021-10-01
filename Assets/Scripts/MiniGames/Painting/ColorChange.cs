using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public Material[] materials;
    public Renderer rend;

    private int index = 1;

    public void ButtonPressed()
    {
        if(materials.Length == 0)
            return;
            index += 1;

            if (index == materials.Length + 1) 
                index = 1;
            print(index);

        rend.sharedMaterial = materials[index = 1];
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
