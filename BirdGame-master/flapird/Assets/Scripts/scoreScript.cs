using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreScript : MonoBehaviour
{
    public int scoredPoints;
    // this refers to the score it self 
    public Text Score, highScore;
    // this will store a UI element of the type Text 
    public bool OK = false;
    // this is to control things until the game has started
    private GameObject player;
    // we want to access the player controller from lola
    void Start()
    {
        Score.enabled = false;
        player = GameObject.FindWithTag("Player");
        highScore.text = "BEST :" +PlayerPrefs.GetInt("Highscore", 0).ToString();
    }

    // Update is called once per frame
    void Update()

    {
            Score.text = scoredPoints.ToString();
            if (scoredPoints > PlayerPrefs.GetInt("Highscore",0)) {
                PlayerPrefs.SetInt("Highscore", scoredPoints);
                highScore.text = "BEST :" +scoredPoints.ToString();
            }
       
        
    }
    public void gameStart() {
        Score.enabled = true;
        // set the score normally when the play button is closed
        OK = true;
        // this is set to true when the player presses the play button
      
    }
   
}
