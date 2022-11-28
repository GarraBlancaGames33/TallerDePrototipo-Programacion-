using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class MostrarBalasEnUI : MonoBehaviour
{
    public TextMeshProUGUI HojasRecogidas;
    public Disparar Disparar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HojasRecogidas.text = Disparar.balas.ToString();
    }
}
