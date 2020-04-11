using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popups : MonoBehaviour
{
    private Powerups Display;
    public SpriteRenderer lifebar;
    // Start is called before the first frame update
    void Start()
    {
       // Display = FindObjectOfType<Powerups>();
        lifebar = GetComponent<SpriteRenderer>();
        lifebar.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (lifebar.enabled == true)
        {
            
        }
    }
    
    
}
