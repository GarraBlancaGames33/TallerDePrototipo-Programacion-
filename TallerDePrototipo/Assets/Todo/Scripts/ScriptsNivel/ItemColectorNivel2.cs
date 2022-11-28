using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemColectorNivel2 : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI hojasText;
    [SerializeField] TextMeshProUGUI hojasTextEnPausa;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Hoja2"))
        {
            Destroy(other.gameObject);
            ItemManager.current.hojasnivel2++;
            hojasText.text = ItemManager.current.hojasnivel2 + "/14";
            hojasTextEnPausa.text = ItemManager.current.hojasnivel2 + "/14";
            AudioManager.instance.PlayAudio(AudioManager.instance.AgarrarHoja);
        }
    }
}
