using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    [SerializeField] GameObject ControlsMenu;

    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Home(int sceneID)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

    public void Controls()
    {
        ControlsMenu.SetActive(true);
        pauseMenu.SetActive(false);
        //Time.timeScale = 1f;
    }

    public void ReturnToPause()
    {
        pauseMenu.SetActive(true);
        ControlsMenu.SetActive(false);
    }
}
