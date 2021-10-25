using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Full Name:        Tyler Miles
Student ID:       101251005
File:             WolfBehaviour.cs
Description:      This is the wolf behaviour script that moves the wolf from right to left and will despawn the wolf once it goes off screen.
Date last modified: Oct 24, 2021
Revision history: Allowed the bat to move from right to left then later added ability to increase speed the closer it gets to player.
*/

public class WolfBehavior : MonoBehaviour
{
    // Start is called before the first frame update


    public float horizontalSpeed;
    public float horizontalBoundary;

    public GameObject wolf;

    void Start()
    {

    }

    void Update()
    {
        _Move();
        _CheckBounds();

        if (horizontalSpeed < 30)
        {
            horizontalSpeed += (Time.deltaTime);
            Debug.Log(horizontalSpeed);
        }
    }

    private void _Reset()
    {
        Destroy(wolf);
    }

    private void _Move()
    {
        transform.position -= new Vector3(horizontalSpeed, 0.0f) * Time.deltaTime;
    }

    private void _CheckBounds()
    {

        if (transform.position.x <= -horizontalBoundary)
        {
            _Reset();
        }
    }
}
