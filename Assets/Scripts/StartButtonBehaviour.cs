using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
Full Name:        Tyler Miles
Student ID:       101251005
File:             StartButtonBehaviour.cs
Description:      This is the start button behaviour script that loads the game scene
Date last modified: Oct 24, 2021
Revision history: added sound effects
*/
public class StartButtonBehaviour : MonoBehaviour
{

    public AudioSource buttonSFX;
    public void OnStartButtonPressed()
    {
        buttonSFX.Play();
        SceneManager.LoadScene(2);
    }
}
