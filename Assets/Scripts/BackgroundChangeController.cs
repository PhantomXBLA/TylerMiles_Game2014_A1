using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundChangeController : MonoBehaviour
{


    public GameObject RedBackground;
    public GameObject GreenBackground;

    float scrollSpeed;
    bool canChange = true;

    public AudioSource transitionSound;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scrollSpeed = GreenBackground.gameObject.GetComponentInChildren<BackgroundController>().horizontalSpeed;
        //Debug.Log(scrollSpeed);
        if(scrollSpeed >= 25 && canChange == true)
        {
            RedBackground.SetActive(true);
            transitionSound.Play();
            GreenBackground.SetActive(false);
            canChange = false;
           

        }
    }
}
