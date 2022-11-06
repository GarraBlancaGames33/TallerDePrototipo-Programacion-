using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorMuere : MonoBehaviour
{

    public ObstaculoMata ObstaculoMata;
    public EnemigoMata EnemigoMata;
    public ZonaMata ZonaMata;
    public GameObject GameManager;
    public bool GameManagerBool = false;

    public GameObject Resultado;
    public bool ResultadoBool = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MostrarCanvasCuandoMuere()
    {
        Resultado.SetActive(true);
        ResultadoBool = true;
    }
}
