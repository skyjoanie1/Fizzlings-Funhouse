using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperLine : MonoBehaviour
{
    public LineRenderer line;
    public Transform post1;
    public Transform post2;
    public Transform post3;
    public Transform post4;
    public Transform post5;
    public Transform post6;
    public Transform post7;


    // Start is called before the first frame update
    void Start()
    {
        line.positionCount = 7;
    }

    // Update is called once per frame
    void Update()
    {
        line.SetPosition(0, post1.position);
        line.SetPosition(1, post2.position);
        line.SetPosition(2, post3.position);
        line.SetPosition(3, post4.position);
        line.SetPosition(4, post5.position);
        line.SetPosition(5, post6.position);
        line.SetPosition(6, post7.position);
    }
}
