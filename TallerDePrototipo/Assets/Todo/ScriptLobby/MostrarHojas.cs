using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MostrarHojas : MonoBehaviour
{
    public TextMeshProUGUI TextoNivel1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TextoNivel1.text = ItemManager.current.hojas + "/14";
    }
}
