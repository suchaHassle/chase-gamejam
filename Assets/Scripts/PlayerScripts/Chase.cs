using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.AI; //needed for the NavMeshAgent property to be used

public class Chase : MonoBehaviour
{
    public Transform goal; //this is where we will input the players object name

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        NavMeshAgent agent = GetComponent<NavMeshAgent>(); //NavMesh is what will make the enemy go to the player
        agent.destination = goal.position; //enemy(agent) will then go to players(goal) position
        //NavMeshAgent.destination property with the point you want the agent to move to. 
        //As soon as the calculation is finished, the agent will automatically move along the path until it reaches its destination.
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.collider.CompareTag("Player"))
        {
            int playerScore = GameObject.Find("Tile").GetComponent<FloorGeneration>().count;
            GameObject.Find("HighScore").GetComponent<HighScoreKeeper>().playerScore = playerScore;
            SceneManager.LoadScene("Game Over");
        }
    }
}
