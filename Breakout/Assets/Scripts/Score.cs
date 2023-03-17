using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System.IO;

public class Score : MonoBehaviour
{
    public TMP_Text highscoreText;
    public TMP_Text scoreText;
    public Highscore highscoreSO;
    public int score = 0;
    
    void Start()
    {
        highscoreText = GameObject.Find("Highscore (TMP)").GetComponent<TMP_Text>();
        scoreText = GameObject.Find("Score (TMP)").GetComponent<TMP_Text>();
        scoreText.text = "Score: 0";
        highscoreText.text = "Highscore: " + highscoreSO.highscore;
    }

    void Update()
    {
        scoreText.text = "Score: " + score;
        if (score > highscoreSO.highscore)
        {
            highscoreSO.highscore = score;
            highscoreText.text = "Highscore: " + highscoreSO.highscore;
        }
    }

    public void IncreaseScore(int amount)
    {
        score += amount;
    }
}
