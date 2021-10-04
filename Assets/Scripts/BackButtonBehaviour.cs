using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Back Button, Tyler Miles, 10251005, Last Modified 03-Oct-2021, Loads Start Scene When Pressed
public class BackButtonBehaviour : MonoBehaviour
{
    public void BackButtonPressed()
    {
        //Debug.Log("Button Tapped!");
        SceneManager.LoadScene(0);
    }
}
