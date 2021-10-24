using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehaviour : MonoBehaviour
{
    public float horizontalSpeed;
    public float horizontalBoundary;
    public GameObject coin;
    // Start is called before the first frame update
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
        Destroy(coin);
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
