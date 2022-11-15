using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JugadorLento : MonoBehaviour
{
    public PlayerController PlayerController;
    public Material Material;
    public GameObject Jugador;
    public bool Enfrenar = false;
    public int FrenarQueAgarro;
    public GameObject ObjetoQueFrena;
    public bool ActivarContadorFreno = false;
    public float ContadorFreno = 0f;
    public GameObject ImagenLenta;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Enfrenar)
        {
            Destroy(ObjetoQueFrena);
        }

        if (FrenarQueAgarro == 1 && Input.GetKeyDown(KeyCode.E))
        {
            PlayerController.MovimientoHaciaAdelante = 2f;
            ActivarContadorFreno = true;
            JugadorLento1();
            FrenarQueAgarro = 0;
            ImagenLenta.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
        if (ActivarContadorFreno)
        {
            ContadorFreno = ContadorFreno + 1 * Time.deltaTime;
        }
        if (ContadorFreno >= 1.5f)
        {
            PlayerController.MovimientoHaciaAdelante = 5f;
            ActivarContadorFreno = false;
            ContadorFreno = 0;
            ColorNormal();

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Frenar")
        {
            Enfrenar = true;
            FrenarQueAgarro = FrenarQueAgarro + 1;
            ImagenLenta.GetComponent<Image>().color = new Color32(17, 33, 197, 255);
        }
    }

    public void JugadorLento1()
    {
        Jugador.GetComponent<Renderer>().material.color = new Color32(17, 33, 197, 255);
    }
    public void ColorNormal()
    {
        Jugador.GetComponent<Renderer>().material.color = new Color32(68, 197, 79, 255);
    }

}
