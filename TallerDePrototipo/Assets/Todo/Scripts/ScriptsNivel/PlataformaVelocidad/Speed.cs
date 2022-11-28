using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : MonoBehaviour
{
    public PlayerController PlayerController;
    public bool enSalto = false;

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        switch (hit.gameObject.name)
        {
            case "PlataformaSpeed":
                PlayerController.MovimientoHaciaAdelante = 10f;
                break;
            case "2":
                PlayerController.MovimientoHaciaAdelante = 5f;
                break;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Salto")
        {
            enSalto = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.name == "Salto")
        {
            enSalto = false;
        }
    }
}
