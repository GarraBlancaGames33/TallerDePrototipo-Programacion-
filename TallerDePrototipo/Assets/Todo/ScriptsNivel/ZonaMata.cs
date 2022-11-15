using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ZonaMata : MonoBehaviour
{
    public GameObject Jugador;
    public bool JugadorVivo = true;
    public JugadorMuere JugadorMuere;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") //Si el jugador cae al vacio o colisiona con un enemigo y el jugador esta vivo
        {
            JugadorVivo = false; //El jugador muere
            Destroy(Jugador); //Desaparece el jugador
            JugadorMuere.MostrarCanvasCuandoMuere();
            ItemManager.current.hojas = 0;
        }
    }
}
