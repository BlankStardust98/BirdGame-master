using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreCount : MonoBehaviour
{
    private GameObject ScoreManager;
    // this is the score manager in the current scene
   
    private void Start()
    {
        ScoreManager = GameObject.Find("ScoreManager");
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) {
            Debug.Log("collided");
            // i was testing something
            ScoreManager.GetComponent<scoreScript>().scoredPoints++;
            // if the pillars intersections collide with the player then increase the score value by one
        }
    }
   
}
