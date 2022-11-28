using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirarPlayer : MonoBehaviour
{
    public Transform Player;
    public PlayerController PlayerController;
    public bool EstaEnGiro = false;
    public bool movimientoNormal = true;
    public bool GiroAlreves = false;
    public float rotacionJugador;
    float yR = 0;

    // Start is called before the first frame update
    void Start()
    {
        rotacionJugador = Player.transform.rotation.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (EstaEnGiro)
        {
            rotacionJugador -= yR;

            rotacionJugador = Mathf.Clamp(rotacionJugador, 90, 90);

            Player.transform.rotation = Quaternion.Euler(0, rotacionJugador, 0);
        }
        if (movimientoNormal)
        {
            rotacionJugador += yR;

            rotacionJugador = Mathf.Clamp(rotacionJugador, 0, 0);

            Player.transform.rotation = Quaternion.Euler(0, rotacionJugador, 0);
        }
        if (GiroAlreves)
        {
            rotacionJugador += yR;

            rotacionJugador = Mathf.Clamp(rotacionJugador, -90, -90);

            Player.transform.rotation = Quaternion.Euler(0, rotacionJugador, 0);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "GIro90Grados")
        {
            EstaEnGiro = true;
            movimientoNormal = false;
            GiroAlreves = false;
        }
        if(other.name == "1")
        {
            EstaEnGiro = false;
            movimientoNormal = true;
            GiroAlreves = false;
        }
        if(other.name == "GiroAlreves")
        {
            EstaEnGiro = false;
            movimientoNormal = false;
            GiroAlreves = true;
        }
    }
}
