using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemCollector : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI hojasText;
    [SerializeField] TextMeshProUGUI hojasTextEnPausa;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Hoja"))
        {
            Destroy(other.gameObject);
            ItemManager.current.hojas++;
            hojasText.text = ItemManager.current.hojas + "/9";
            hojasTextEnPausa.text = ItemManager.current.hojas + "/9";
            AudioManager.instance.PlayAudio(AudioManager.instance.AgarrarHoja);
        }
    }
}
