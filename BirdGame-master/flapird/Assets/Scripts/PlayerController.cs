using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float birdSpeed = 0;
    public Rigidbody2D rb;
    public GameObject lola;
    public UImanager UI;
    public bool gameEnded;
    public UImanager restart;
    // this will check for when the player dies
    
    // Start is called before the first frame update
    void Start()
    {
        rb  = GetComponent<Rigidbody2D>();

        lola.GetComponent<Rigidbody2D>().gravityScale = 0; ;
        UI = FindObjectOfType<UImanager>();
        restart = FindObjectOfType<UImanager>();
        
        
    }

    // Update is called once per frame
   public  void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * birdSpeed;
        }
        
    }
    // the below should be  for the resetting instead Of restart probably for powerups
   /*public void RestartGame()
   {
       StartCoroutine("RestartGameCoroutine");
   }    

   public IEnumerator RestartGameCoroutine()
   {
       yield return new WaitForSeconds(2f);
       Time.timeScale = 1f;
       transform.position = new Vector2(lola.transform.position.x, lola.transform.position.y);
       UI.Panel.gameObject.SetActive(true);
   }*/

   public void OnTriggerEnter2D(Collider2D coll)
   {
       if (coll.tag == "pipe" || coll.tag == "ground")

       {
            gameEnded = true;
           UI.Panel.gameObject.SetActive(true);
           restart.Restartbutton.SetActive(true);
          Time.timeScale = 0;
           // if live is gained ask the player to use it or not. if not

            //RestartGame();
       }
       
   }
}
