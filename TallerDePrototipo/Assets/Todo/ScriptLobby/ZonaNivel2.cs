using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZonaNivel2 : MonoBehaviour
{
    public int numeroEscena;
    public ItemCollector ItemCollector;
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
        if (other.tag == "Player" && ItemManager.current.hojas >= 7)
        {
            SceneManager.LoadScene(numeroEscena);
        }
    }
}
