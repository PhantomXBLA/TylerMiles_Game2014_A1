using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
Full Name:        Tyler Miles
Student ID:       101251005
File:             HowToPlayButtonBehaviour.cs
Description:      This is the how to play button behaviour script that loads the how to play scene
Revision history: added sound effects
*/
public class HowToPlayButtonBehaviour : MonoBehaviour
{
    public AudioSource buttonSFX;
    public void HowToPlayButtonPressed()
    {
        buttonSFX.Play();
        SceneManager.LoadScene(1);
    }
}
