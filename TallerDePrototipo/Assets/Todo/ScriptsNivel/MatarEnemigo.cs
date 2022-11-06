using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MatarEnemigo : MonoBehaviour
{
    public GameObject Enemigo; //Object del enemigo
    public bool EnemigoVivo = true; //El jugador empieza vivo

    public BoxCollider BX; //Box colider del enemigo

    private void Update()
    {
        if(EnemigoVivo == false) //Si el enemigo muere
        {
            Enemigo.SetActive(false); //El enemigo desaparece
            BX.enabled = false; //Desactiva el box colider para que no mande al jugador al lobby
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        EnemigoVivo = false; //Si el jugador colisiona arriba del enemigo, el enemigo muere
    }
}
