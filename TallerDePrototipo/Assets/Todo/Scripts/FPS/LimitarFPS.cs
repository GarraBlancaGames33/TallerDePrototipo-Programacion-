using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitarFPS : MonoBehaviour
{
    private int limiteFPS = 60;

    private void Start()
    {
        Application.targetFrameRate = limiteFPS;
    }
}
