using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MatarJefe : MonoBehaviour
{
    public GameObject Enemigo; //Object del enemigo
    public bool EnemigoVivo = true; //El jugador empieza vivo
    public float vida = 10;
    public float vidaMaxima = 10;

    public BoxCollider BXArriba; //Box colider del enemigo
    public int BossMuerto = 0;

    public Image BarraVida;



    private void Update()
    {
        BarraVida.fillAmount = vida / vidaMaxima;
        if (vida == 0) //Si el enemigo muere
        {
            Enemigo.SetActive(false); //El enemigo desaparece
            BXArriba.enabled = false; //Desactiva el box colider para que no mande al jugador al lobby
        }

        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bala")
        {
            vida = vida - 1;
        }
    }
}
