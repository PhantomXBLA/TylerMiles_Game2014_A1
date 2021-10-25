using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
