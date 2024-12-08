using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    [SerializeField] GameObject HowtoPlayMenu;
    [SerializeField] GameObject HowtoPlayMenu2;
    [SerializeField] GameObject resetButton;
    [SerializeField] GameObject selectScreen;

    public void MainMenu(int sceneID)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

    public void SelectLevel(int sceneID)
    {
        //ScoreManager.instance.scoreText.text = "Score: " + 0.ToString();
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneID);   
    }
    
    public void SelectScreen()
    {
        selectScreen.SetActive(true);
        resetButton.SetActive(false);
    }

    public void HowToPlay()
    {
        HowtoPlayMenu.SetActive(true);
        resetButton.SetActive(false);
    }

    public void HowToPlayMenu2()
    {
        HowtoPlayMenu2.SetActive(true);
        resetButton.SetActive(false);
    }

    public void HowToPlayMenu2Hide()
    {
        HowtoPlayMenu2.SetActive(false);
    }

    public void ExitGame(int sceneID)
    {
        //Debug.Log("Game is now Closing... Goodbye");
        Application.Quit();
    }
}
