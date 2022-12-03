using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IniciarJuego : MonoBehaviour
{


    public int numeroEscena;

    private void Update()
    {
        Iniciar();
    }
    public void Iniciar()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(numeroEscena);
        }
        
    }

}
