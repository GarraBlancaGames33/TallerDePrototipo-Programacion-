using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    [Header("Movement")]
    public float movementSpeed;

    public float groundDrag;

    public float JumpForce;
    public float jumoCooldown;
    public float airMultiplier;

    [Header("KeyBinds")]
    public KeyCode jumpkey = KeyCode.Space;



    [Header("Ground Check")]
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask whatIsGround;
    public bool grounded;


    public Transform orientation;

    float horizontalInput;
    float verticalInput;

    Vector3 movedirecction;

    Rigidbody RB;
    public Animacion Animacion;

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>();
        RB.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        grounded = Physics.CheckSphere(groundCheck.position, groundDistance, whatIsGround);

        MyInput();
        SpeedControl();

        if (grounded)
        {
            RB.drag = groundDrag;
        }
        else
        {
            RB.drag = 0;
        }
        if (Input.GetKeyUp(jumpkey))
        {
            Animacion.anim.SetBool("Salto", false);
        }
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void MyInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        if(Input.GetKey(jumpkey) && grounded)
        {
            Jump();
            Animacion.anim.SetBool("Salto", grounded);
            
        }
    }

    private void MovePlayer()
    {
        movedirecction = orientation.forward * verticalInput + orientation.right * horizontalInput;
        if (grounded)
        {
            RB.AddForce(movedirecction.normalized * movementSpeed * 10f, ForceMode.Force);
        }
        else if (!grounded)
        {
            RB.AddForce(movedirecction.normalized * movementSpeed * 10f * airMultiplier, ForceMode.Force);
        }
    }

    private void SpeedControl()
    {
        Vector3 flatvel = new Vector3(RB.velocity.x, 0f, RB.velocity.z);

        if(flatvel.magnitude > movementSpeed)
        {
            Vector3 limitedVel = flatvel.normalized * movementSpeed;
            RB.velocity = new Vector3(limitedVel.x, RB.velocity.y, limitedVel.z);
        }
    }

    private void Jump()
    {
        RB.velocity = new Vector3(RB.velocity.x, 0f, RB.velocity.z);

        RB.AddForce(transform.up * JumpForce, ForceMode.Impulse);

    }

}
