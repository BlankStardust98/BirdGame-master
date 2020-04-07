using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{
    // Accessing another script.
    public PlayerController Accessgravity;
    public scrollingbackground Quadmove;
    public GameObject PlayButton, namebutton,Spawner,Panel;
    //public obstaclesScripts moveRods;
    
   
    
    // Start is called before the first frame update
        void Start()
    {
        
            Accessgravity = FindObjectOfType<PlayerController>();
            Quadmove = FindObjectOfType<scrollingbackground>();
          
            PlayButton.SetActive(true);
            namebutton.SetActive(true);
            Spawner.gameObject.SetActive(false);
            Panel.gameObject.SetActive(false);
           
            
        
    }

    // Update is called once per frame
   public void PlayGame()
    {
        Accessgravity.lola.GetComponent<Rigidbody2D>().gravityScale = 1f;
        Accessgravity.birdSpeed = 4.5f;
        Quadmove.backgroundSpeed = 0.6f;
        Spawner.gameObject.SetActive(true);
       // moveRods.pipeSpeed = 3f;
       // makes the playbutton disappear after clicking.
        PlayButton.SetActive(false);
       // nameofgame.text.GetComponent<Text>().enabled = false;
        namebutton.SetActive(false);
       
       
        
        

    }
} 
