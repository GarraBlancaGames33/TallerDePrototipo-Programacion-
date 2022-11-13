using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoMata : MonoBehaviour
{
    public MatarEnemigo MatarEnemigo;
    public GameObject Jugador;
    public bool JugadorVivo = true;
    public JugadorMuere JugadorMuere;

    public GameObject Enemigo;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && MatarEnemigo.EnemigoVivo == true) //Si el jugador cae al vacio o colisiona con un enemigo y el jugador esta vivo
        {
            JugadorVivo = false; //El jugador muere
            Destroy(Jugador); //Desaparece el jugador
            JugadorMuere.MostrarCanvasCuandoMuere();
        }
        if(other.tag == "Bala")
        {
            Enemigo.SetActive(false);
        }
    }
}
