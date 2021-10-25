using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Full Name:        Tyler Miles
Student ID:       101251005
File:             BatBehaviour.cs
Description:      This is the bat behaviour script that moves the bat from right to left, and up and down, will despawn the bat once it goes off screen.
Revision history: Allowed the bat to move from right to left then later added ability to move up and down.
*/

public class BatBehaviour : MonoBehaviour
{
    public GameObject bat;
    public float horizontalSpeed;
    public float horizontalBoundary;

    public float verticalBoundaryTop;
    public float verticalBoundaryBottom;

    float direction = 1;
    void Start()
    {

    }

    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Reset()
    {
        Destroy(bat);
    }

    private void _Move()
    {
        transform.position -= new Vector3(horizontalSpeed, horizontalSpeed*direction) * Time.deltaTime;
    } 

    private void _CheckBounds()
    {

        if (transform.position.x <= -horizontalBoundary)
        {
            _Reset();
        }

        //check top boundary
        if (transform.position.y >= verticalBoundaryTop)
        {
            direction = 1.0f;
        }

        // check bottom boundary
        if (transform.position.y <= verticalBoundaryBottom)
        {
            direction = -1.0f;
        }
    }
}
