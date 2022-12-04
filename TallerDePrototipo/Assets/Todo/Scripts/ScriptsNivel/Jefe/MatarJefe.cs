using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MatarJefe : MonoBehaviour
{
    public GameObject Enemigo; //Object del enemigo
    public bool EnemigoVivo = true; //El jugador empieza vivo
    public float vida = 9;
    public float vidaMaxima = 9;

    public BoxCollider BXArriba; //Box colider del enemigo
    public bool BossMuerto = false;

    public Image BarraVida;

    public float Cuenta = 0;
    public int Escena;
    public Animator anim;


    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        BarraVida.fillAmount = vida / vidaMaxima;
        if (vida == 0) //Si el enemigo muere
        {
            BossMuerto = true; //El enemigo desaparece
            BXArriba.enabled = false; //Desactiva el box colider para que no mande al jugador al lobby
        }
        if(BossMuerto)
        {
            Cuenta = Cuenta + 1 * Time.deltaTime;
            anim.SetBool("Muere", true);

        }
        if(Cuenta >= 5)
        {
            Enemigo.SetActive(false);
            SceneManager.LoadScene(Escena);
            
        }

        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bala")
        {
            vida = vida - 1;
        }
    }
}
