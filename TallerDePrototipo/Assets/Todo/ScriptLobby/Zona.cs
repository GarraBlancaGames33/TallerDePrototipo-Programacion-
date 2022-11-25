using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Zona : MonoBehaviour
{
    public int numeroEscena;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            SceneManager.LoadScene(numeroEscena);
            //Carga.NivelCarga("NIvel1Lag"); //Para hacer una pantalla de carga
            ItemManager.current.hojas = 0;
        }
    }
}
