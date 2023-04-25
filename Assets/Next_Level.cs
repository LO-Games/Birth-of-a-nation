using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next_Level : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(
            "Shooting_Scene"
        );
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
