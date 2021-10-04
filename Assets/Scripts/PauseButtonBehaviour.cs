using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Pause Button, Tyler Miles, 10251005, Last Modified 03-Oct-2021, Pause  Game When Pressed
public class PauseButtonBehaviour : MonoBehaviour
{

    [SerializeField]
    GameObject PauseMenu;
    public void OnPauseButtonPressed()
    {
        //Debug.Log("Button Tapped!");
        //SceneManager.LoadScene(2);

        PauseMenu.SetActive(!PauseMenu.activeSelf);
    }
}
