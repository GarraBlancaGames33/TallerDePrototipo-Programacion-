using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public float MovimientoHaciaAdelante = 5f;
    public float jumpForce;
    public float gravityScale = 5f;

    private Vector3 moveDirecction;

    public CharacterController controller;

    public Transform groundCheck;
    public float groundDistance = 0.3f;
    public LayerMask groundMask;

    bool isGrounded;

    public GirarPlayer GirarPlayer;

    public Speed Speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        float yStore = moveDirecction.y;

        if (GirarPlayer.movimientoNormal)
        {
            moveDirecction = new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed, 0f, MovimientoHaciaAdelante);
            moveDirecction = moveDirecction * moveSpeed;
            moveDirecction.y = yStore;
        }
       
        if (GirarPlayer.EstaEnGiro)
        {
            moveDirecction = new Vector3(MovimientoHaciaAdelante, 0f, Input.GetAxisRaw("Horizontal") * -moveSpeed);
            moveDirecction = moveDirecction * moveSpeed;
            moveDirecction.y = yStore;
        }
        if (GirarPlayer.GiroAlreves)
        {
            moveDirecction = new Vector3(-MovimientoHaciaAdelante, 0f, Input.GetAxisRaw("Horizontal") * moveSpeed);
            moveDirecction = moveDirecction * moveSpeed;
            moveDirecction.y = yStore;
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            moveDirecction.y = jumpForce;
        }
        if (Speed.enSalto)
        {
            moveDirecction.y = jumpForce * 2;
        }

        moveDirecction.y += Physics.gravity.y * Time.deltaTime * gravityScale;

        controller.Move(moveDirecction * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.S))
        {
            gravityScale = 50f;
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            gravityScale = 5f;
        }
    }


    
}
