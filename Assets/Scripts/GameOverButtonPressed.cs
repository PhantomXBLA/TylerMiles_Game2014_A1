using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
Full Name:        Tyler Miles
Student ID:       101251005
File:             GameOverButtonPressed.cs
Description:      This is an old button that triggered the game over state, not used anymore
Date last modified: Oct 24, 2021
Revision history: set button to inactive, no longer in use, scared to delete
*/
public class GameOverButtonPressed : MonoBehaviour
{
    public void OnGameOverButtonPressed()
    {
        //Debug.Log("Button Tapped!");
        SceneManager.LoadScene(3);
    }
}
