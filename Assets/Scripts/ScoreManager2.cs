using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager2 : MonoBehaviour
{
    public static ScoreManager2 instance;

    public TextMeshProUGUI scoreText;

    int score;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    public void ChangeScore(int coinValue, int enemyValue, int enemyBossValue)
    {
        score += coinValue;
        score += enemyValue;
        UpdateScoreText();
    }
}
