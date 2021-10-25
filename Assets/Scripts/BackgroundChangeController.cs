using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
Full Name:        Tyler Miles
Student ID:       101251005
File:             BackgroundChangeController.cs
Description:      This is the background change controller script that checks the speed of the background then changes it to the other background once a certain speed threshold is reached
Revision history: Created the speed check to swap background then added sound effect.
*/


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
