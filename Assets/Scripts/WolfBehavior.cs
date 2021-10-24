using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfBehavior : MonoBehaviour
{
    // Start is called before the first frame update


    public float horizontalSpeed;
    public float horizontalBoundary;

    public GameObject wolf;
    public float tempSpeed;

    void Start()
    {
        horizontalSpeed = tempSpeed;
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
        tempSpeed = horizontalSpeed;
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
