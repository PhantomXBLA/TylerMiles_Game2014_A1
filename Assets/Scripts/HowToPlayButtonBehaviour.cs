using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//HowToPlayButton, Tyler Miles, 10251005, Last Modified 03-Oct-2021, Loads How to Play when Pressed
public class HowToPlayButtonBehaviour : MonoBehaviour
{
    public AudioSource buttonSFX;
    public void HowToPlayButtonPressed()
    {
        buttonSFX.Play();
        SceneManager.LoadScene(1);
    }
}
