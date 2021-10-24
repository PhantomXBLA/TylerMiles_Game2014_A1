using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{

    public float horizontalSpeed;
    public float horizontalBoundaryLeft;
    public float horizontalBoundaryRight;
    public float resetPosZ;

    public GameObject scrollingPrefab;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();

        if (horizontalSpeed < 30)
        {
            horizontalSpeed += Time.deltaTime;
            //Debug.Log(horizontalSpeed);
        }
    }

    private void _Reset()
    {
        this.scrollingPrefab.transform.position = new Vector3(horizontalBoundaryRight, scrollingPrefab.transform.position.y, resetPosZ);
    }

    private void _Move()
    {
        scrollingPrefab.transform.position -= new Vector3(horizontalSpeed, 0.0f) * Time.deltaTime;
    }

    private void _CheckBounds()
    {

        if (scrollingPrefab.transform.position.x <= horizontalBoundaryLeft)
        {
            _Reset();
        }
    }
}
