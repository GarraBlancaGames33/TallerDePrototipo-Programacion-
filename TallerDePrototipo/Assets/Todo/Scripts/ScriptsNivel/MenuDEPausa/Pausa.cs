using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausa : MonoBehaviour
{
    public GameObject Panel;

    public GameObject Hojas;
    public GameObject Tinta;
    //public GameObject Rapido;
    //public GameObject Lento;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            EnPausa();
        }
        
    }

    public void EnPausa()
    {
        Time.timeScale = 0f;
        Panel.SetActive(true);
        Hojas.SetActive(false);
        Tinta.SetActive(false);
        //Rapido.SetActive(false);
        //Lento.SetActive(false);
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }
    public void Reanudar()
    {
        Time.timeScale = 1f;
        Panel.SetActive(false);
        Hojas.SetActive(true);
        Tinta.SetActive(true);
        //Rapido.SetActive(true);
        //Lento.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
