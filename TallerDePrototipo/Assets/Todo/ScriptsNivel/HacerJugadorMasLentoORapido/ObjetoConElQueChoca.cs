using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoConElQueChoca : MonoBehaviour
{
    public bool EnAcelerar;
    public GameObject ObjetoQueAcelera;
    public int AcelerarQueAgarro;
    public PlayerController PlayerController;
    public float contador = 0f;
    public bool ActivarContador = false;
    public Material Material;
    public GameObject Jugador;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (EnAcelerar)
        {
            Destroy(ObjetoQueAcelera);  
        }
        if(AcelerarQueAgarro == 1 && Input.GetKeyDown(KeyCode.Q)) // Aumentar la velocidad del jugador al agarrar el objeto y apretar la Q
        {
            PlayerController.MovimientoHaciaAdelante = 10f;
            ActivarContador = true;
            ColorVelocidad();
            AcelerarQueAgarro = 0;

        }
        if (ActivarContador)
        {
            contador = contador + 1 * Time.deltaTime;
        }
        if(contador >= 1.5f)
        {
            PlayerController.MovimientoHaciaAdelante = 5f;
            ActivarContador = false;
            ColorNormal();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Acelerar")
        {
            EnAcelerar = true;
            AcelerarQueAgarro = AcelerarQueAgarro + 1;
        }
    }

    public void ColorVelocidad()
    {
        Jugador.GetComponent<Renderer>().material.color = new Color32(195, 46, 17, 255);
    }
    public void ColorNormal()
    {
        Jugador.GetComponent<Renderer>().material.color = new Color32(68, 197, 79, 255);
    }


}
