using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmunitionPickUp : MonoBehaviour
{
    [SerializeField] private int ammunitionCount;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.GetComponent<PlayerController>() != null)
        {
            AmmunitionManager.instance.AddAmmunition(ammunitionCount);
            Destroy(gameObject);
        }
    }
}
