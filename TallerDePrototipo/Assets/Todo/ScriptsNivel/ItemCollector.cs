using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    int hojas = 0;

    [SerializeField] Text hojasText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Hoja"))
        {
            Destroy(other.gameObject);
            hojas++;
            hojasText.text = " " + hojas;
        }
    }
}
