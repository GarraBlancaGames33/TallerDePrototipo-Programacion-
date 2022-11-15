using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    [SerializeField] Text hojasText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Hoja"))
        {
            Destroy(other.gameObject);
            ItemManager.current.hojas++;
            hojasText.text = ItemManager.current.hojas + "/14";
        }
    }
}
