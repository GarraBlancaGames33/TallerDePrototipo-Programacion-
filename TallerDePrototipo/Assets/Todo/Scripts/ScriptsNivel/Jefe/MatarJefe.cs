using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatarJefe : MonoBehaviour
{
    public GameObject Enemigo; //Object del enemigo
    public bool EnemigoVivo = true; //El jugador empieza vivo

    public BoxCollider BXArriba; //Box colider del enemigo
    public int BossMuerto = 0;


    private void Update()
    {
        if (BossMuerto == 3) //Si el enemigo muere
        {
            Enemigo.SetActive(false); //El enemigo desaparece
            BXArriba.enabled = false; //Desactiva el box colider para que no mande al jugador al lobby
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bala")
        {
            BossMuerto = BossMuerto + 1;
        }
    }
}
