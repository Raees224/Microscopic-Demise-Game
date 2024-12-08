using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetScoreScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ScoreManager.instance.ResetScore();
    }

    public void SelectLevel(int sceneID)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneID);
    }
}
