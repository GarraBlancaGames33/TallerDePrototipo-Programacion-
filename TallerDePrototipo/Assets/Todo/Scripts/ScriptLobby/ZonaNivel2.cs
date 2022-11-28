using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZonaNivel2 : MonoBehaviour
{
    public int numeroEscena;
    public ItemCollector ItemCollector;
    public GameObject Niebla;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ItemManager.current.hojas >= 3)
        {
            Niebla.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && ItemManager.current.hojas >= 3)
        {
            SceneManager.LoadScene(numeroEscena);
            
        }
    }
}
