using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//GameOverButton, Tyler Miles, 10251005, Last Modified 03-Oct-2021, Loads Game Over Scene when Pressed (demonstration only)
public class GameOverButtonPressed : MonoBehaviour
{
    public void OnGameOverButtonPressed()
    {
        //Debug.Log("Button Tapped!");
        SceneManager.LoadScene(3);
    }
}
