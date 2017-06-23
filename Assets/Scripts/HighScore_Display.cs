using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class HighScore_Display : MonoBehaviour
{
    Text scoreDisplay;
    // Use this for initialization
    void Start()
    {
        scoreDisplay = gameObject.GetComponent<Text>();
        int score = GameObject.Find("HighScore").GetComponent<HighScoreKeeper>().highScore;
        if (score != 0)
           scoreDisplay.text = "The high score is " + score + ". Try to beat it!";
        else {
            scoreDisplay.text = "try to get the highest score!";
            scoreDisplay.fontSize = 30;
        }
    }
}
