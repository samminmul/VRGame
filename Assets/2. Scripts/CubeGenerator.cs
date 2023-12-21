using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenerator : MonoBehaviour
{
    [SerializeField] GameObject cube;

    void Start()
    {
        Vector3 summonPos = new Vector3(0, 0, 100);
        Instantiate(cube, summonPos, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
