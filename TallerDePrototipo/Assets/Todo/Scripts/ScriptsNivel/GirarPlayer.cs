using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirarPlayer : MonoBehaviour
{
    public Transform Player;
    public PlayerController PlayerController;
    public bool EstaEnGiro90 = false;
    public bool EstaEnGiro180 = false;
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
        if (EstaEnGiro90)
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
        if (EstaEnGiro180)
        {
            rotacionJugador -= yR;

            rotacionJugador = Mathf.Clamp(rotacionJugador, 180, 180);

            Player.transform.rotation = Quaternion.Euler(0, rotacionJugador, 0);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "GIro90Grados")
        {
            EstaEnGiro90 = true;
            movimientoNormal = false;
            GiroAlreves = false;
            EstaEnGiro180 = false;
        }
        if(other.name == "1")
        {
            EstaEnGiro90 = false;
            movimientoNormal = true;
            GiroAlreves = false;
            EstaEnGiro180 = false;
        }
        if(other.name == "GiroAlreves")
        {
            EstaEnGiro90 = false;
            movimientoNormal = false;
            GiroAlreves = true;
            EstaEnGiro180 = false;
        }
        if(other.name == "Giro190Grados")
        {
            EstaEnGiro180 = true;
            EstaEnGiro90 = false;
            movimientoNormal = false;
            GiroAlreves = false;
        }
    }
}
