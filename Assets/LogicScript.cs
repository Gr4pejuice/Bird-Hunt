using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;

    public int highScore;
    public Text highScoreText;

    public int playerHealth = 3;
    public int numOfHearts;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    public GameObject gameOverScreen;
    public bool gameIsOver = false;

    // Start is called before the first frame update
    private void Update()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < playerHealth)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }

            if (i<numOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }

        if (playerHealth <= 0)
        {
            gameOver();
            gameIsOver = true;
        }
    }

    public void addScore()
    {
        playerScore += 1;
        scoreText.text = playerScore.ToString();
        checkScore();
    }

    public void loseHealth()
    {
        playerHealth -= 1;
    }

    public void checkScore()
    {
        if (playerScore > PlayerPrefs.GetInt("highScore", 0))
        {
            PlayerPrefs.SetInt("highScore", playerScore);
        }
    }    

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        highScoreText.text = "High Score: " + PlayerPrefs.GetInt("highScore").ToString();
    }

}
