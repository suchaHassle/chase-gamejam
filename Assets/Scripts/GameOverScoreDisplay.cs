using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScoreDisplay : MonoBehaviour {
    Text scoreDisplay;
    // Use this for initialization
    void Start()
    {
        int playerScore = GameObject.Find("HighScore").GetComponent<HighScoreKeeper>().playerScore;
        int highScore = GameObject.Find("HighScore").GetComponent<HighScoreKeeper>().highScore;
        scoreDisplay = gameObject.GetComponent<Text>();
        if (playerScore > highScore)
        {
            GameObject.Find("HighScore").GetComponent<HighScoreKeeper>().highScore = playerScore;
            scoreDisplay.text = "YOU GOT " + playerScore + "! A HIGH SCORE!!!!!!!!!!";
        }
        else
            scoreDisplay.text = "YOU GOT " + playerScore + "! TRY TO BEAT " + highScore;
    }
   
}

