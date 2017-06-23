using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayScoreDisplay : MonoBehaviour {

    Text scoreDisplay;

    private void Start()
    {
        scoreDisplay = gameObject.GetComponent<Text>();
       
    }
    // Update is called once per frame
    void Update () {
        int playerScore = GameObject.Find("Tile").GetComponent<FloorGeneration>().count; // Get this score from the tile count. 
        scoreDisplay.text = "Score: " + playerScore; 
    }
}
