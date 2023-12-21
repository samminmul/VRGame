using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickManager : MonoBehaviour
{
    UIManager UImanager;
    public void Awake()
    {
        UImanager = GetComponent<UIManager>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit) && hit.collider.CompareTag("Ball"))
            {
                Destroy(hit.collider.gameObject);
                UImanager.SetScore(1);
            }
        }
    }
}
