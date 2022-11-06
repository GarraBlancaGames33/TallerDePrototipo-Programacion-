using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CargarBalas : MonoBehaviour
{
    public Disparar Disparar;
    public GameObject Cargador;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Disparar.balas = Disparar.balas + 1;
            Cargador.SetActive(false);
        }
        
    }
}
