using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJefe : MonoBehaviour
{
    public bool EnTerritorio = false;
    public bool AlAlzanza = false;
    public GameObject JefeMata;
    public MatarJefe MatarJefe;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(MatarJefe.vida > 0 && AlAlzanza)
        {
            JefeMata.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "TerrirorioJefe")
        {
            EnTerritorio = true;
            AlAlzanza = false;
        }
        if(other.name == "AlAlzanza")
        {
            AlAlzanza = true;
            EnTerritorio = false;
            
        }
    }
}
