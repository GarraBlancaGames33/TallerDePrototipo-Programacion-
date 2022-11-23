using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
    public GameObject bala;
    public GameObject FirePoint;
    public CargarBalas CargarBalas;

    public int balas;
    


    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && balas > 0)
        {
            Instantiate(bala, FirePoint.transform.position,FirePoint.transform.rotation);
            balas = balas - 1;
        }
    }
}
