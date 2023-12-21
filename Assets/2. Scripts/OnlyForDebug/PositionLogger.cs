using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionLogger : MonoBehaviour
{
    Transform tr;

    void Start()
    {
        tr = GetComponent<Transform>();    
    }

    void Update()
    {
        Debug.Log($"{this.gameObject.name}: ({tr.position.x}, {tr.position.y}, {tr.position.z})");
    }
}
