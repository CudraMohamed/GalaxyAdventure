using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    private bool totalScore;
    public AudioSource scoreSound;
    // public ScoreManager UpdateScore;
    // public GameObject ScoreAudio;


    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
       if(!totalScore)
       {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
        scoreSound.Play();
       }
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        totalScore = true;
        gameOverScreen.SetActive(true);
    }
}
