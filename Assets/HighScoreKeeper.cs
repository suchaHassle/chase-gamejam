using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScoreKeeper : MonoBehaviour {

    public int highScore = 0;
    public int playerScore = 0; 
	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(this);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
