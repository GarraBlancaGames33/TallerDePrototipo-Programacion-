using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJefe : MonoBehaviour
{
    public bool EnTerritorio = false;
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
        if(other.name == "TerrirorioJefe")
        {
            EnTerritorio = true;
        }
    }
}
