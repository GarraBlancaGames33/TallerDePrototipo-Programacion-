using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MostrarBalasEnUI : MonoBehaviour
{
    public Text HojasRecojidas;
    public Disparar Disparar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HojasRecojidas.text = Disparar.balas.ToString();
    }
}
