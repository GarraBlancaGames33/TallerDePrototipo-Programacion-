using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ZonaMata : MonoBehaviour
{
    public GameObject Jugador;
    public bool JugadorVivo = true;
    public JugadorMuere JugadorMuere;
    public Sombra Sombra;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") //Si el jugador cae al vacio o colisiona con un enemigo y el jugador esta vivo
        {
            JugadorVivo = false; //El jugador muere
            Destroy(Jugador); //Desaparece el jugador
            JugadorMuere.MostrarCanvasCuandoMuere();
            Sombra.moveSpeed = 0;
            Sombra.movimientohaciaAdelante = 0;
            Destroy(Sombra.DestruirSombra);
        }
    }
}
