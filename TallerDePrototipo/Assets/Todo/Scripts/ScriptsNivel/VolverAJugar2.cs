using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VolverAJugar2 : MonoBehaviour
{
    public int numeroDeEscena;

    private void Update()
    {

    }

    public void VolverAjugarFuncion()
    {
        SceneManager.LoadScene(numeroDeEscena);
        Time.timeScale = 1;
        ItemManager.current.hojasnivel2 = 0;
    }
}
