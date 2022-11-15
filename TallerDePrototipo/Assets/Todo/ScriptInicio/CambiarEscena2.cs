using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscena2 : MonoBehaviour
{
    public int numeroEscena;
    public void Lobby()
    {
        SceneManager.LoadScene(numeroEscena);
    }

}
