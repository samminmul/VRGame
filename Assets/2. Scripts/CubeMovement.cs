using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    Transform tr;

    void Start()
    {
        tr = GetComponent<Transform>();
    }

    
    void Update()
    {
        Vector3 speed = new Vector3(0, 0, -0.1f);
        tr.Translate(speed);
    }
}
