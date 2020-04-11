using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UImanager : MonoBehaviour
{
    // Accessing another script.
    public PlayerController Accessgravity;
    public scrollingbackground Quadmove;
    public parallaxMountain Pspeed;
    public GameObject PlayButton, namebutton,Spawner,Panel,Displayedlife,Quitbutton,Optionsbutton,Backbutton,Restartbutton;
    public bool StartGame = false;
   
    //public obstaclesScripts moveRods;
    // Start is called before the first frame update
        void Start()
    {
            Accessgravity = FindObjectOfType<PlayerController>();
            Quadmove = FindObjectOfType<scrollingbackground>();
              Pspeed = FindObjectOfType<parallaxMountain>();
           // PlayButton btn = PlayButton.GetComponent<Button>();
       // btn.onClick.AddListener(PlayGame);
            PlayButton.SetActive(true);
            namebutton.SetActive(true);
            Spawner.gameObject.SetActive(false);
            Panel.gameObject.SetActive(false);
             Backbutton.SetActive(false);
            Restartbutton.SetActive(false);
    }
           

    // Update is called once per frame
   public void PlayGame()
    {
        StartGame = true; 
          Accessgravity.lola.GetComponent<Rigidbody2D>().gravityScale = 1f;
        Accessgravity.birdSpeed = 4.5f;
        Quadmove.backgroundSpeed = 0.6f;
        Spawner.gameObject.SetActive(true);
       // moveRods.pipeSpeed = 3f;
       // makes the playbutton disappear after clicking.
        PlayButton.SetActive(false);
        Optionsbutton.SetActive(false);
        Quitbutton.SetActive(false);
        // nameofgame.text.GetComponent<Text>().enabled = false;
        namebutton.SetActive(false);
   }
    public void QuitGame()
    {
        // i want to quit the game
        Debug.Log("Quit!");
        Application.Quit();
           
    }
    public void OptionsButton()
    {
        Quadmove.backgroundSpeed = 0f;
        Pspeed.speed = 0;
        PlayButton.SetActive(false);
        Quitbutton.SetActive(false);
        Backbutton.SetActive(true);
        Optionsbutton.SetActive(false);
    }
    public void BackButton()
    {
        // this method allows the backbutton to return to its calling Process
        Backbutton.SetActive(false);
        PlayButton.SetActive(true);
        Quitbutton.SetActive(true);
        Optionsbutton.SetActive(true);
    }
    public void RestartGame()
    {
        // the restartbutton reloads the scene, thereby resetting the score and all
        SceneManager.LoadScene("flapird");
        Time.timeScale = 1f;
    }
    
} 
