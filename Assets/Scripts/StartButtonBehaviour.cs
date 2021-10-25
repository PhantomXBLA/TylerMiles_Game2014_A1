using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//StartButton, Tyler Miles, 10251005, Last Modified 03-Oct-2021, Loads Game Scene when Start Button Pressed
public class StartButtonBehaviour : MonoBehaviour
{

    public AudioSource buttonSFX;
    public void OnStartButtonPressed()
    {
        buttonSFX.Play();
        SceneManager.LoadScene(2);
    }
}
