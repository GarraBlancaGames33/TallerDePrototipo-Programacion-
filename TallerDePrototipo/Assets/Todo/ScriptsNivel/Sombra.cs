using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sombra : MonoBehaviour
{
    public float moveSpeed;

    public JugadorMuere JugadorMuere;

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

        if (JugadorMuere.ObstaculoMata.JugadorVivo == false || JugadorMuere.EnemigoMata.JugadorVivo == false || JugadorMuere.ZonaMata.JugadorVivo == false) //Si el jugador esta muerto por la zona,enemigo o caida
        {
            movimientohaciaAdelante = 0; //Movimiento hacia adelante baja a 0 (no se mueve)
            moveSpeed = 0; //Movimiento lateral baja a 0
            DestruirSombra.SetActive(false); //El Jugador desaparece
            JugadorMuere.MostrarCanvasCuandoMuere();
        }
    }   
}
