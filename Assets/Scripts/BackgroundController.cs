using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{

    public float horizontalSpeed;
    public float horizontalBoundaryLeft;
    public float horizontalBoundaryRight;
    public float resetPosZ;

    public GameObject GroundPrefab;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Reset()
    {
        this.GroundPrefab.transform.position = new Vector3(horizontalBoundaryRight, GroundPrefab.transform.position.y, resetPosZ);
    }

    private void _Move()
    {
        GroundPrefab.transform.position -= new Vector3(horizontalSpeed, 0.0f) * Time.deltaTime;
    }

    private void _CheckBounds()
    {

        if (GroundPrefab.transform.position.x <= horizontalBoundaryLeft)
        {
            _Reset();
        }
    }
}
