using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
Full Name:        Tyler Miles
Student ID:       101251005
File:             PauseButtonBehaviour.cs
Description:      This is the pause button behaviour script that loads pause menu
Revision history: added sound effects
*/
public class PauseButtonBehaviour : MonoBehaviour
{

    [SerializeField]
    GameObject PauseMenu;

    public AudioSource pauseSFX;
    public void OnPauseButtonPressed()
    {
        //Debug.Log("Button Tapped!");
        //SceneManager.LoadScene(2);


        PauseMenu.SetActive(!PauseMenu.activeSelf);
        pauseSFX.Play();

    }
}
