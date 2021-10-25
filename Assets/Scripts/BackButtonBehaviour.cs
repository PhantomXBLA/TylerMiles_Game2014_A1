using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
Full Name:        Tyler Miles
Student ID:       101251005
File:             BackButtonBehaviour.cs
Description:      This is the back button, when the button is pressed it plays the SFX and loads the main menu.
Revision history: Added sound fx
*/

public class BackButtonBehaviour : MonoBehaviour
{

    public AudioSource buttonSFX;
    public void BackButtonPressed()
    {
        //Debug.Log("Button Tapped!");
        buttonSFX.Play();
        SceneManager.LoadScene(0);
    }
}
