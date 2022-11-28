using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausaLobby : MonoBehaviour
{
    public GameObject Panel;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            EnPausa();
        }

    }

    public void EnPausa()
    {
        Time.timeScale = 0f;
        Panel.SetActive(true);
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }
    public void Reanudar()
    {
        Time.timeScale = 1f;
        Panel.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
