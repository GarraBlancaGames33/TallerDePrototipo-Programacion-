using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
    public GameObject bala;
    public GameObject FirePoint;


    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(bala, FirePoint.transform.position,FirePoint.transform.rotation);
        }
    }
}
