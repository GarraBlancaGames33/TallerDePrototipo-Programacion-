using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaculoMata : MonoBehaviour
{
    public GameObject Jugador;
    public bool JugadorVivo = true;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") //Si el jugador cae al vacio o colisiona con un enemigo y el jugador esta vivo
        {
            JugadorVivo = false; //El jugador muere
            Destroy(Jugador); //Desaparece el jugador
        }
    }
}
