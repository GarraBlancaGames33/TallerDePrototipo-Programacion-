using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoDispara : MonoBehaviour
{
    public GameObject bala;
    public GameObject FirePoint;
    public CargarBalas CargarBalas;

    public int balas;

    public int tiempo;



    void Start()
    {

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && balas > 0)
        {
            Instantiate(bala, FirePoint.transform.position, FirePoint.transform.rotation);
            balas = balas - 1;
        }
    }
}
