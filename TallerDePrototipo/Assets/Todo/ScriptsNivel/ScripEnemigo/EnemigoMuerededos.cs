using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoMuerededos : MonoBehaviour
{
    public MatarEnemigo MatarEnemigo;
    public GameObject Jugador;
    public bool JugadorVivo = true;
    public JugadorMuere JugadorMuere;

    public GameObject Enemigo;

    public GameObject EnemigoCubo;

    public int vidas = 2;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && MatarEnemigo.EnemigoVivo == true) //Si el jugador cae al vacio o colisiona con un enemigo y el jugador esta vivo
        {
            JugadorVivo = false; //El jugador muere
            Destroy(Jugador); //Desaparece el jugador
            ItemManager.current.hojas = 0;
            JugadorMuere.MostrarCanvasCuandoMuere();
        }
        if (other.tag == "Bala")
        {
            vidas = vidas - 1;
        }
    }
    public void Update()
    {
        if (vidas == 0)
        {
            Enemigo.SetActive(false);
        }

        if (vidas == 1)
        {
            EnemigoCubo.GetComponent<Renderer>().material.color = new Color32(159, 38, 38, 255);
        }
    }
}
