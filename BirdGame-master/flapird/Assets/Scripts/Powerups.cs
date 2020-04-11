using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Powerups : MonoBehaviour
{
    
    public float powerupsSpeed;
    public GameObject life;
    public Popups bar;
    
    // Start is called before the first frame update
    void Start()
    {
        bar = FindObjectOfType<Popups>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * powerupsSpeed * Time.deltaTime;
    }

    public void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Player")
        {
            
            Destroy(life);
            bar.lifebar.enabled = true;


        }
    }
}
