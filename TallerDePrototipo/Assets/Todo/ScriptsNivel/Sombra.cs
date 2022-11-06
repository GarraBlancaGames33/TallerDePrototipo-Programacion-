using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sombra : MonoBehaviour
{
    public float moveSpeed;

    public int movimientohaciaAdelante = 5;

    private Vector3 moveDirecction;

    public CharacterController controller;

    public GameObject DestruirSombra;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveDirecction = new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed, 0f, movimientohaciaAdelante);
        moveDirecction = moveDirecction * moveSpeed;
        controller.Move(moveDirecction * Time.deltaTime);
    }   
}
