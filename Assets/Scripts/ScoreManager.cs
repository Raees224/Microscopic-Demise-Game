using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverTotalScoreText;
    public TextMeshProUGUI levelDoneTotalScoreText;

    //public TextMeshProUGUI highScoreText;

    int score;
    int highScore;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }

        scoreText.text = "Score: " + PlayerPrefs.GetInt("currentScore", score).ToString();  //Change scoreUI text whenever the player gets a point
        //totalText.text = "Total Score: " + PlayerPrefs.GetInt("currentScore", score).ToString();
        
        score = PlayerPrefs.GetInt("currentScore", score);            //Allows score to be save and use on different scenes
        //highScore = PlayerPrefs.GetInt("currentScore", score);


    }

    public void UpdateScoreText()
    {
        //scoreText.text = "Score: " + score.ToString();
    }

    public void ResetScore()
    {
            
        //if (highScore < score)
        //PlayerPrefs.SetInt("highScore", highScore);

        PlayerPrefs.DeleteKey("currentScore");
    }

    public void ChangeScore(int coinValue, int enemyValue, int enemyBossValue)
    {
        score += coinValue;
        score += enemyValue;
        score += enemyBossValue;

        scoreText.text = "Score: " + score.ToString();
        gameOverTotalScoreText.text = "Total Score: " + score.ToString();
        levelDoneTotalScoreText.text = "Total Score: " + score.ToString();

        PlayerPrefs.SetInt("currentScore", score);

        //PlayerPrefs.SetInt("totalScore", score);

        //highScore = PlayerPrefs.GetInt("totalScore", score);
        //highScoreText.text = "High Score: " + PlayerPrefs.GetInt("totalScore", score).ToString();

        //PlayerPrefs.Save();
    }
}
