using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeMueve : MonoBehaviour
{
    public MovimientoJefe MovimientoJefe;
    private Vector3 moveDirecction;
    float moveSpeed = 4f;
    float MovimientoHaciaAdelante = 5f;
    public CharacterController controller;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (MovimientoJefe.EnTerritorio)
        {
            moveDirecction = new Vector3(0 ,0,MovimientoHaciaAdelante);
            moveDirecction = moveDirecction * moveSpeed;

            controller.Move(moveDirecction * Time.deltaTime);
        }
    }
}
