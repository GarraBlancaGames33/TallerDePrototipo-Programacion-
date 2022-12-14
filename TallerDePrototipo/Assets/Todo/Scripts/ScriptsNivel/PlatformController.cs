using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    public Rigidbody platformRB;
    public Transform[] platformPositions;
    public float platformSpeed;

    private int actualPosition = 0;
    private int nextPosition = 1;

    private void Update()
    {
        MovePlatform();
    }

    void MovePlatform()
    {
        platformRB.MovePosition(Vector3.MoveTowards(platformRB.position, platformPositions[nextPosition].position, platformSpeed * Time.deltaTime));

        if (Vector3.Distance(platformRB.position, platformPositions[nextPosition].position) <= 0)
        {
            actualPosition = nextPosition;
            nextPosition++;

            if(nextPosition > platformPositions.Length - 1)
            {
                nextPosition = 0;
            }
        }
    }
}
