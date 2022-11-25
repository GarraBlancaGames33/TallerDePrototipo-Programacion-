using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Cargando : MonoBehaviour
{
    public Text Texto;
    // Start is called before the first frame update
    void Start()
    {
        string nivelACargar = Carga.siguienteNivel;
        StartCoroutine(IniciarCarga(nivelACargar));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator IniciarCarga(string nivel)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(nivel);
        operation.allowSceneActivation = false;

        while (!operation.isDone)
        {
            if (operation.progress >= 0.9f)
            {
                Texto.text = "Pulsar espacio para continuar";
                if (Input.anyKey)
                {
                    operation.allowSceneActivation = true;
                }
            }
            yield return null;
        }
    }
}
