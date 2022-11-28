using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Libro : MonoBehaviour
{
    public Transform[] views;
    public float transitionSpeed;
    Transform currentview;

    public GameObject PrimeraPantalla;
    public GameObject SegundaPantalla;


    // Start is called before the first frame update
    void Start()
    {
        currentview = transform;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentview = views[0];
            PrimeraPantalla.SetActive(false);
            SegundaPantalla.SetActive(true);
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
        }
    }

    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, currentview.position, Time.deltaTime * transitionSpeed);
    }
}
